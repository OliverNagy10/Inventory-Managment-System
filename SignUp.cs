using Google.Cloud.Firestore;
using Inventory_Management_System;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace Inventory_Managment_System
{
    public partial class SignUp : Form
    {
        FirestoreDb db = FirestoreDb.Create("inventory-management-sys-df9e8");
        private const string FirebaseApiKey = "AIzaSyAz7GmkdHjccaWX8oogwq7rzmMMqI20Nc0"; // Replace with your Firebase project's API key
        private const string FirebaseSignUpUrl = "https://identitytoolkit.googleapis.com/v1/accounts:signUp?key=" + FirebaseApiKey;

        public SignUp()
        {
            InitializeComponent();
            InitializeFirebase();
        }

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
                        var signUpResponse = JsonConvert.DeserializeObject<SignInResponse>(responseContent);

                        CollectionReference companiesCollection = db.Collection("companies");

                        // Set the document ID to the user's ID token
                        DocumentReference newCompanyRef = companiesCollection.Document(signUpResponse.localId);

                        newCompanyRef.SetAsync(new
                        {
                            name = companyName,
                            email = email
                        });

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

                        // Optionally, you can proceed with additional actions, e.g., opening the login form or performing other actions.

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

        private void LogInClick(object sender, EventArgs e)
        {
            LoginFormView view = new LoginFormView();
            LoginModel model = new LoginModel();
            LoginController login = new LoginController(view, model);
            view.Show();
            this.Hide();
        }

        
    }
}