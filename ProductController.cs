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
    }
}
