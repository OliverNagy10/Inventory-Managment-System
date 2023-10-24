using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using Inventory_Managment_System;

namespace Inventory_Management_System
{
    public class SignUpModel
    {
      
       
      

        public async Task<SignInResponse> SignUpAsync(string email, string password, string companyName, FirestoreDb db , string FirebaseSignUpUrl)
        {
            try
            {
                var signUpData = new
                {
                    email,
                    password,
                    returnSecureToken = true
                };

                var json = JsonConvert.SerializeObject(signUpData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (var client = new HttpClient())
                {
                    var response = await client.PostAsync(FirebaseSignUpUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        var signUpResponse = JsonConvert.DeserializeObject<SignInResponse>(responseContent);

                        CollectionReference companiesCollection = db.Collection("companies");

                        // Set the document ID to the user's ID token
                        DocumentReference newCompanyRef = companiesCollection.Document(signUpResponse.localId);

          await   newCompanyRef.SetAsync(new
                        {
                            name = companyName,
                            email = email
                        });

                        // Add "users" and "products" collections to the new document
                await   newCompanyRef.Collection("users").Document("initialUser").CreateAsync(new
                        {
                            // Add user details here if needed
                        });

                 await  newCompanyRef.Collection("products").Document("initialProduct").CreateAsync(new
                        {
                            // Add product details here if needed
                        });

                        return signUpResponse;
                    }
                    else
                    {
                        var errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(await response.Content.ReadAsStringAsync());
                        throw new Exception("Sign-up failed: " + errorResponse.error.message);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred: " + ex.Message);
            }
        }
    }
}
