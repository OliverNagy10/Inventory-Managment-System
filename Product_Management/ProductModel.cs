using Google.Cloud.Firestore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System
{
    public class ProductModel
    {
        private FirestoreDb db;
        private string IDToken;
        private string userId;

        public ProductModel(FirestoreDb firestoreDb, string idToken)
        {
            db = firestoreDb;
            IDToken = idToken;
            this.userId = GetUserIdFromFirebaseAuthentication();

        }

        public async Task<string> AddProductAsync(string productName, string description, string supplier, double price, int quantity, int barcode , double cost)
        {
            // Ensure the user is logged in or otherwise handle the authentication status
           

            if (userId == null)
            {
                return "User is not authenticated.";
            }

            try
            {
                // Get a reference to the company's document in the "companies" collection
                DocumentReference companyRef = db.Collection("companies").Document(userId);

                // Get a reference to the "products" collection within the company's document
                CollectionReference productsCollection = companyRef.Collection("products");

                // Check if a product with the same name already exists
                QuerySnapshot querySnapshot = await productsCollection.WhereEqualTo("Name", productName).GetSnapshotAsync();

                if (querySnapshot.Count > 0)
                {
                    return "Product with the same name already exists.";
                }
                else
                {
                    // Create a new product document with the product name as the document ID
                    DocumentReference newProductRef = productsCollection.Document(productName);

                    var newProduct = new
                    {
                        Name = productName,
                        Description = description,
                        Supplier = supplier,
                        Barcode = barcode,
                        Cost  = cost,
                        Price = price,
                        Quantity = quantity
                    };

                    // Add the new product document to the "products" collection
                    await newProductRef.SetAsync(newProduct);

                    return "Product added successfully.";
                }
            }
            catch (Exception ex)
            {
                return "An error occurred: " + ex.Message;
            }
        }

        public async Task<string> DeleteProductAsync(string productName)
        {
            try
            {
            

                if (userId == null)
                {
                    return "User is not authenticated.";
                }

                // Get a reference to the company's document in the "companies" collection
                DocumentReference companyRef = db.Collection("companies").Document(userId);

                // Get a reference to the "products" collection within the company's document
                CollectionReference productsCollection = companyRef.Collection("products");

                // Query to retrieve the product document with the specified name
                QuerySnapshot querySnapshot = await productsCollection.WhereEqualTo("Name", productName).GetSnapshotAsync();

                if (querySnapshot.Count == 1)
                {
                    // Retrieve the product document reference
                    DocumentReference productDocumentRef = querySnapshot.Documents[0].Reference;

                    // Delete the product document
                    await productDocumentRef.DeleteAsync();

                    return "Product deleted successfully.";
                }
                else
                {
                    return "Product not found.";
                }
            }
            catch (Exception ex)
            {
                return "An error occurred: " + ex.Message;
            }
        }


        public async Task<string> UpdateProductAsync(string originalName, string newName, string description, string supplier, double price, int quantity , int barcode, double cost)
        {
            try
            {
            

                if (userId == null)
                {
                    return "User is not authenticated.";
                }

                // Get a reference to the company's document in the "companies" collection
                DocumentReference companyRef = db.Collection("companies").Document(userId);

                // Get a reference to the "products" collection within the company's document
                CollectionReference productsCollection = companyRef.Collection("products");

                // Query to retrieve the product document with the original name
                QuerySnapshot querySnapshot = await productsCollection.WhereEqualTo("Name", originalName).GetSnapshotAsync();

                if (querySnapshot.Count == 1)
                {
                    // Retrieve the original product document reference
                    DocumentReference productDocumentRef = querySnapshot.Documents[0].Reference;

                    // Create a new dictionary with the updated values, including the new name
                    var updates = new Dictionary<string, object>
            {
                { "Name", newName },
                { "Description", description },
                { "Supplier", supplier },
                { "Barcode",barcode },
                { "Cost", cost },
                { "Price", price },
                { "Quantity", quantity }
            };

                    // Update the fields of the product document using the dictionary
                    await productDocumentRef.UpdateAsync(updates);

                    // Create a new product document with the new name
                    DocumentReference newProductRef = productsCollection.Document(newName);

                    // Copy the contents of the original document to the new one
                    DocumentSnapshot originalProductSnapshot = await productDocumentRef.GetSnapshotAsync();
                    if (originalProductSnapshot.Exists)
                    {
                        await newProductRef.SetAsync(originalProductSnapshot.ToDictionary());
                    }

                    

                    return "Product updated successfully.";
                }
                else
                {
                    return "Product not found.";
                }
            }
            catch (Exception ex)
            {
                return "An error occurred: " + ex.Message;
            }
        }



        public async Task<(string name, string description, string supplier, int barcode ,double cost,   double price, int quantity )> SearchProductAsync(string productName)
        {
            try
            {
             

                if (userId == null)
                {
                    return (null, null, null, 0,  0.0, 0.0, 0);
                }

                // Get a reference to the company's document in the "companies" collection
                DocumentReference companyRef = db.Collection("companies").Document(userId);

                // Get a reference to the "products" collection within the company's document
                CollectionReference productsCollection = companyRef.Collection("products");

                // Query to retrieve the product document with the specified name
                QuerySnapshot querySnapshot = await productsCollection.WhereEqualTo("Name", productName).GetSnapshotAsync();

                if (querySnapshot.Count == 1)
                {
                    // Retrieve the product document data
                    var productDocument = querySnapshot.Documents[0];
                    return (
                        productDocument.GetValue<string>("Name"),
                        productDocument.GetValue<string>("Description"),
                        productDocument.GetValue<string>("Supplier"),
                        productDocument.GetValue<int>("Barcode"),
                        productDocument.GetValue<double>("Cost"),
                        productDocument.GetValue<double>("Price"),
                        productDocument.GetValue<int>("Quantity")
                    );
                }
                else
                {
                    // Product not found or multiple products with the same name exist
                    return (null, null, null, 0, 0,0, 0);
                }
            }
            catch (Exception ex)
            {
                // Handle any errors
                Console.WriteLine("An error occurred: " + ex.Message);
                return (null, null, null, 0,0, 0, 0);
            }
        }

        public async Task<(string name, string description, string supplier ,int barcode, double cost, double price, int quantity)> SearchProductByBarcodeAsync(int productBarcode)
        {
            try
            {
                

                if (userId == null)
                {
                    return (null, null, null, 0, 0, 0.0, 0);
                }

                // Get a reference to the company's document in the "companies" collection
                DocumentReference companyRef = db.Collection("companies").Document(userId);

                // Get a reference to the "products" collection within the company's document
                CollectionReference productsCollection = companyRef.Collection("products");

                // Query to retrieve the product document with the specified barcode
                QuerySnapshot querySnapshot = await productsCollection.WhereEqualTo("Barcode", productBarcode).GetSnapshotAsync();

                if (querySnapshot.Count == 1)
                {
                    // Retrieve the product document data
                    var productDocument = querySnapshot.Documents[0];
                    return (
                        productDocument.GetValue<string>("Name"),
                        productDocument.GetValue<string>("Description"),
                        productDocument.GetValue<string>("Supplier"),
                        productDocument.GetValue<int>("Barcode"),
                         productDocument.GetValue<int>("Cost"),
                        productDocument.GetValue<double>("Price"),
                        productDocument.GetValue<int>("Quantity")
                    );
                }
                else
                {
                    // Product not found or multiple products with the same barcode exist
                    return (null, null, null, 0, 0, 0, 0);
                }
            }
            catch (Exception ex)
            {
                // Handle any errors
                Console.WriteLine("An error occurred: " + ex.Message);
                return (null, null, null, 0, 0, 0, 0);
            }
        }

        public async Task<List<(string name, string description, string supplier, int barcode, double cost , double price, int quantity)>> GetProductDetailsAsync()
        {
            try
            {
               
                if (userId == null)
                {
                    Console.WriteLine("User is not authenticated.");
                    return new List<(string, string, string, int, double ,double, int)>(); // User is not authenticated
                }

                // Get a reference to the company's document in the "companies" collection
                DocumentReference companyRef = db.Collection("companies").Document(userId);

                // Get a reference to the "products" collection within the company's document
                CollectionReference productsCollection = companyRef.Collection("products");

                // Query to retrieve all product documents
                QuerySnapshot querySnapshot = await productsCollection.GetSnapshotAsync();

                var productDetailsList = new List<(string, string, string, int,double, double, int)>();

                foreach (var productDocument in querySnapshot.Documents)
                {
                    // Retrieve the product document data
                    var productDetails = (
                        productDocument.GetValue<string>("Name"),
                        productDocument.GetValue<string>("Description"),
                        productDocument.GetValue<string>("Supplier"),
                        productDocument.GetValue<int>("Barcode"),
                        productDocument.GetValue<double>("Cost"),
                        productDocument.GetValue<double>("Price"),
                        productDocument.GetValue<int>("Quantity")
                    );

                    productDetailsList.Add(productDetails);
                }

                Console.WriteLine("Successfully retrieved product details.");
                return productDetailsList;
            }
            catch (Exception ex)
            {
                // Handle any errors
                Console.WriteLine("An error occurred: " + ex.Message);
                return new List<(string, string, string, int,double, double, int)>();
            }
        }

        public async Task<string> UpdateProductQuantityAsync(string productName, int quantityChange)
        {
            try
            {
            

                if (userId == null)
                {
                    return "User is not authenticated.";
                }

                // Get a reference to the company's document in the "companies" collection
                DocumentReference companyRef = db.Collection("companies").Document(userId);

                // Get a reference to the "products" collection within the company's document
                CollectionReference productsCollection = companyRef.Collection("products");

                // Query to retrieve the product document with the specified name
                QuerySnapshot querySnapshot = await productsCollection.WhereEqualTo("Name", productName).GetSnapshotAsync();

                if (querySnapshot.Count == 1)
                {
                    // Retrieve the product document reference
                    DocumentReference productDocumentRef = querySnapshot.Documents[0].Reference;

                    // Retrieve the current quantity
                    int currentQuantity = querySnapshot.Documents[0].GetValue<int>("Quantity");

                    // Calculate the new quantity
                    int newQuantity = currentQuantity + quantityChange;

                    if (newQuantity < 0)
                    {
                        return "Quantity cannot be negative.";
                    }

                    // Update the quantity in the product document
                    await productDocumentRef.UpdateAsync(new Dictionary<string, object>
            {
                { "Quantity", newQuantity }
            });

                    return "Product quantity updated successfully.";
                }
                else
                {
                    return "Product not found.";
                }
            }
            catch (Exception ex)
            {
                return "An error occurred: " + ex.Message;
            }
        }

        public async Task<string> GetProductNameById(string productId)
        {
            try
            {
                

                if (userId == null)
                {
                    return null;
                }

                // Get a reference to the company's document in the "companies" collection
                DocumentReference companyRef = db.Collection("companies").Document(userId);

                // Get a reference to the "products" collection within the company's document
                CollectionReference productsCollection = companyRef.Collection("products");

                // Query to retrieve the product document with the specified ID
                QuerySnapshot querySnapshot = await productsCollection.WhereEqualTo("ProductId", productId).GetSnapshotAsync();

                if (querySnapshot.Count == 1)
                {
                    // Retrieve the product document and get its name
                    return querySnapshot.Documents[0].GetValue<string>("Name");
                }
                else
                {
                    // Product not found or multiple products with the same ID exist
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Handle any errors
                Console.WriteLine("An error occurred: " + ex.Message);
                return null;
            }
        }


        public string GetUserIdFromFirebaseAuthentication()
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
    }
}
