using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Stripe;
using Stripe.Checkout;
using System.Configuration;
using Inventory_Managment_System.Checkout_Management;

namespace Inventory_Managment_System.Sales_Manager
{
    public class CheckoutModel
    {
        public List<Product> basket;
        private ProductModel productManager;
        private FirestoreDb db;
       
     
       




        public CheckoutModel(ProductModel productManager, FirestoreDb firestoreDb)
        { 

            this.productManager = productManager;
            this.db = firestoreDb;
            
            
       
            basket = new List<Product>();
            // Move the Stripe configuration inside the constructor
            string stripeApiKey = ConfigurationManager.AppSettings["StripeApiKey"];
            StripeConfiguration.ApiKey = stripeApiKey;
          

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
            await CreateSalesDocumentAsync();
            // Clear the basket
            basket.Clear();


        }

       


        public async Task CheckoutWithCardAsync()
        {
            // Create a list of line items for the Stripe payment
            List<SessionLineItemOptions> lineItems = new List<SessionLineItemOptions>();

            foreach (var item in basket)
            {
                lineItems.Add(new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        Currency = "usd", // Replace with your currency
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = item.Name,
                        },
                        UnitAmount = (long)(item.Price * 100), // Amount in cents
                    },
                    Quantity = item.Quantity
                });
            }

            // Create a Stripe session for the payment
            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string> { "card" },
                LineItems = lineItems,
                Mode = "payment",
                SuccessUrl = "https://yourwebsite.com/success",
                CancelUrl = "https://yourwebsite.com/cancel"
            };

            var service = new SessionService();
            var session = await service.CreateAsync(options);

            // Get the payment link
            string paymentLink = session.Url;

            // Automatically open the payment link in the default web browser
            System.Diagnostics.Process.Start(paymentLink);

            // After the Stripe payment is successfully fulfilled, create a sales document and perform other checkout operations
            await CreateSalesDocumentAsync();

            // Clear the basket
            basket.Clear();
        }

        private async Task CreateSalesDocumentAsync()
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