using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Stripe;


namespace Inventory_Managment_System.Sales_Manager
{
    public class SalesManager
    {
        public List<Product> basket;
        private ProductModel productManager;
        private FirestoreDb db;

        public SalesManager(ProductModel productManager, FirestoreDb firestoreDb)
        {
            basket = new List<Product>();
            this.productManager = productManager;
            db = firestoreDb;
        }

        public async Task AddToBasketAsync(int productBarcode, int quantity)
        {
            // Search for the product by barcode
            var (name, description, supplier, barcode, price, availableQuantity) = await productManager.SearchProductByBarcodeAsync(productBarcode);

            // Check if the product was found
            if (name != null)
            {
                // Check if the requested quantity is available
                if (quantity <= availableQuantity)
                {
                    // Add the product to the basket
                    basket.Add(new Product
                    {
                        Name = name,
                        Description = description,
                        Supplier = supplier,
                        Barcode = barcode,
                        Price = price,
                        Quantity = quantity
                    });
                }
                else
                {
                    // Handle insufficient quantity
                    Console.WriteLine($"Insufficient quantity of {name} available.");
                }
            }
            else
            {
                // Handle product not found
                Console.WriteLine($"Product with barcode {productBarcode} not found.");
            }
        }

        public void RemoveFromBasket(string productName)
        {
            // Find the item in the basket by product name
            var itemToRemove = basket.Find(product => product.Name == productName);

            if (itemToRemove != null)
            {
                basket.Remove(itemToRemove);
            }
        }

        public double CalculateTotalPrice()
        {
            double total = 0;

            foreach (var item in basket)
            {
                total += item.Price * item.Quantity;
            }

            return total;
        }


        public async Task CheckoutAsync()
        {
            // Get the currently authenticated user's ID
            string userId = await productManager.GetUserIdFromFirebaseAuthenticationAsync();

            if (userId == null)
            {
                throw new InvalidOperationException("User is not authenticated.");
            }

            try
            {
                // Get a reference to the company's document in the "companies" collection
                DocumentReference companyRef = db.Collection("companies").Document(userId);

                // Get a reference to the "sales" collection within the company's document
                CollectionReference salesCollection = companyRef.Collection("sales");

                // Create a new sale document with individual fields
                var saleData = new
                {
                    Date = DateTime.UtcNow, // You can use the current date and time
                    TotalSalePrice = CalculateTotalPrice()
                };

                DocumentReference saleDocRef = await salesCollection.AddAsync(saleData);

                // Save each item in the basket as a separate document in a subcollection
                CollectionReference saleItemsCollection = saleDocRef.Collection("items");
                foreach (var item in basket)
                {
                    var saleItemData = new
                    {
                        Name = item.Name,
                        Description = item.Description,
                        Supplier = item.Supplier,
                        Barcode = item.Barcode,
                        Price = item.Price,
                        Quantity = item.Quantity
                    };
                    await saleItemsCollection.AddAsync(saleItemData);
                }

                // Clear the basket
                basket.Clear();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred: " + ex.Message);
            }
        }


      





    public async Task UpdateProductQuantitiesAsync()
        {
            foreach (var item in basket)
            {
                await productManager.UpdateProductQuantityAsync(item.Name, -item.Quantity);
            }
        }

        
    }
}
