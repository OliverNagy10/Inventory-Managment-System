using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;

namespace Inventory_Managment_System
{
    public class ProductController
    {
        private ProductModel productModel;
        private ProductManagementView productView;
        private FirestoreDb db;
        private string IDToken;

        public ProductController(FirestoreDb firestoreDb, string idToken, ProductManagementView view)
        {
            db = firestoreDb;
            IDToken = idToken;
            productModel = new ProductModel(db, IDToken);
            productView = view;

            productView.SearchButtonClicked += async (sender, args) => await SearchProductAsync();
            // Attach event handler for the Add button click event in the view
            productView.AddButtonClicked += async (sender, args) => await AddProductAsync();
        }

        public async Task AddProductAsync()
        {
            string productName = productView.GetName();
            string description = productView.GetDescription();
            string supplier = productView.GetSupplier();
            double price = productView.GetPrice();
            int quantity = productView.GetQuantity();

            string resultMessage = await productModel.AddProductAsync(productName, description, supplier, price, quantity);

            if (resultMessage.Contains("Error"))
            {
                productView.ShowError(resultMessage);
            }
            else
            {
                productView.ShowSuccess(resultMessage);
            }
        }

        public async Task SearchProductAsync()
        {
            string productName = productView.GetSearchQuery(); // Add a GetSearchQuery method to your view

            if (!string.IsNullOrEmpty(productName))
            {
                var productDetails = await productModel.SearchProductAsync(productName);

                if (productDetails.Item1 != null)
                {
                    // Populate the textboxes with the product details
                    productView.SetName(productDetails.Item1);
                    productView.SetDescription(productDetails.Item2);
                    productView.SetSupplier(productDetails.Item3);
                    productView.SetPrice(productDetails.Item4);
                    productView.SetQuantity(productDetails.Item5);
                }
                else
                {
                    productView.ShowError("Product not found.");
                }
            }
            else
            {
                productView.ShowError("Please enter a product name to search.");
            }
        }

    }
}


    

