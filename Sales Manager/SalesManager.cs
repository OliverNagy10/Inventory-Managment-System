using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Sales_Manager
{
    public class SalesManager
    {
        public List<Product> basket;
        private ProductModel productManager;

        public SalesManager(ProductModel productManager)
        {
            basket = new List<Product>();
            this.productManager = productManager;
        }

        public async Task AddToBasketAsync(string productName, int quantity)
        {
            // Search for the product in the database
            var (name, description, supplier, barcode, price, availableQuantity) = await productManager.SearchProductAsync(productName);

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
                Console.WriteLine($"Product '{productName}' not found.");
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

        public async Task UpdateProductQuantitiesAsync(string product)
        {
            foreach (var item in basket)
            {
                await productManager.UpdateProductQuantityAsync(item.Name, -item.Quantity);
            }
        }
    }
}
