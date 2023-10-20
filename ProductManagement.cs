using System;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text;

namespace Inventory_Managment_System
{
    public partial class ProductManagement : Form
    {
        FirestoreDb db;
        string IDToken;

        public ProductManagement(FirestoreDb firestoreDb , string idtoken)
        {
            IDToken = idtoken;
            InitializeComponent();
            db = firestoreDb;
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            // Ensure the user is logged in or otherwise handle the authentication status
            var userId = GetUserIdFromFirebaseAuthentication();

            if (userId == null)
            {
                MessageBox.Show("User is not authenticated.");
                return;
            }

            string productName = nameBox.Text;
            string description = descriptionBox.Text;
            string supplier = supplierBox.Text;
            double price = double.Parse(priceBox.Text);
            int quantity = int.Parse(quantityBox.Text);

            try
            {
                // Get a reference to the company's document in the "companies" collection
                DocumentReference companyRef = db.Collection("companies").Document(userId);

                // Get a reference to the "products" collection within the company's document
                CollectionReference productsCollection = companyRef.Collection("products");

                // Query to check if a product with the same name already exists
                QuerySnapshot querySnapshot = await productsCollection.WhereEqualTo("Name", productName).GetSnapshotAsync();

                if (querySnapshot.Count > 0)
                {
                    MessageBox.Show("Product with the same name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Create a new product document with the provided data
                    var newProduct = new
                    {
                        Name = productName,
                        Description = description,
                        Supplier = supplier,
                        Price = price,
                        Quantity = quantity
                    };

                    // Add the new product document to the "products" collection
                    await productsCollection.AddAsync(newProduct);

                    // Optionally, you can refresh the product list or show a success message.
                    // RefreshProductList(); // Implement this function to update the product list

                    MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions, e.g., invalid input or database errors
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string GetUserIdFromFirebaseAuthentication()
        {
            // Replace with your Firebase project's API key
            string apiKey = "AIzaSyAz7GmkdHjccaWX8oogwq7rzmMMqI20Nc0";
            string idToken = IDToken; // Retrieve the user's ID token after login

            var httpClient = new HttpClient();
            var requestUri = new Uri($"https://identitytoolkit.googleapis.com/v1/accounts:lookup?key={apiKey}");
            var requestData = new { idToken };
            var jsonRequestData = Newtonsoft.Json.JsonConvert.SerializeObject(requestData);
            var content = new StringContent(jsonRequestData, Encoding.UTF8, "application/json");

            var response = httpClient.PostAsync(requestUri, content).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            dynamic responseJson = JObject.Parse(responseContent);

            string userId = responseJson?.users?[0]?.localId;
            return userId;
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
