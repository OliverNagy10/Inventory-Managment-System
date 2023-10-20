using Google.Cloud.Firestore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Inventory_Managment_System
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            InitializeFirebase();

        }

        FirestoreDb db = FirestoreDb.Create("inventory-management-sys-df9e8");
        private const string FirebaseApiKey = "AIzaSyAz7GmkdHjccaWX8oogwq7rzmMMqI20Nc0";
        private const string FirebaseSignUpUrl = "https://identitytoolkit.googleapis.com/v1/accounts:signUp?key=" + FirebaseApiKey;

        private void InitializeFirebase()
        {
            // No FirebaseAdmin initialization needed for this approach
        }

        private async void SignUp_Load(object sender, EventArgs e)
        {
            string email = companyEmailBox.Text;
            string password = passwordBox.Text;
            string companyName = companyNameBox.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                        
                        CollectionReference companiesCollection = db.Collection("companies");

                        // Create a new document with an automatically generated ID
                        DocumentReference newCompanyRef = companiesCollection.AddAsync(new
                        {
                            name = companyName,
                            email = email
                        }).Result;

                        // Add "users" and "products" collections to the new document
                        newCompanyRef.Collection("users").Document("initialUser").CreateAsync(new
                        {
                            // Add user details here if needed
                        });

                        newCompanyRef.Collection("products").Document("initialProduct").CreateAsync(new
                        {
                            // Add product details here if needed
                        });

                        MessageBox.Show("Sign-up successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Optionally, you can proceed with additional actions, e.g., opening the dashboard form or performing other actions.

                        // Note: You may want to add the user to your Firestore database at this point.
                    }
                    else
                    {
                        var errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(await response.Content.ReadAsStringAsync());
                        MessageBox.Show("Sign-up failed: " + errorResponse.error.message, "Sign-up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error for debugging
                Console.WriteLine("An error occurred: " + ex.ToString());
                // Handle other exceptions
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void companyEmailBox_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
