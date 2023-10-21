﻿using Google.Cloud.Firestore;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System
{
    public class ProductModel
    {
        private FirestoreDb db;
        private string IDToken;

        public ProductModel(FirestoreDb firestoreDb, string idToken)
        {
            db = firestoreDb;
            IDToken = idToken;
        }

        public async Task<string> AddProductAsync(string productName, string description, string supplier, double price, int quantity)
        {
            // Ensure the user is logged in or otherwise handle the authentication status
            var userId = await GetUserIdFromFirebaseAuthenticationAsync();

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

        public async Task<(string name, string description, string supplier, double price, int quantity)> SearchProductAsync(string productName)
        {
            try
            {
                // Get the currently authenticated user's ID
                string userId = await GetUserIdFromFirebaseAuthenticationAsync();

                if (userId == null)
                {
                    return (null, null, null, 0, 0); // User is not authenticated
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
                        productDocument.GetValue<double>("Price"),
                        productDocument.GetValue<int>("Quantity")
                    );
                }
                else
                {
                    // Product not found or multiple products with the same name exist
                    return (null, null, null, 0, 0);
                }
            }
            catch (Exception ex)
            {
                // Handle any errors
                Console.WriteLine("An error occurred: " + ex.Message);
                return (null, null, null, 0, 0);
            }
        }



        private async Task<string> GetUserIdFromFirebaseAuthenticationAsync()
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
