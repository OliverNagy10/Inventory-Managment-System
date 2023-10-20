using Inventory_Managment_System;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
namespace Inventory_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            InitializeFirebase();

        }
        private const string FirebaseApiKey = "AIzaSyAz7GmkdHjccaWX8oogwq7rzmMMqI20Nc0";
        private const string FirebaseSignInUrl = "https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key=" + FirebaseApiKey;

        private void InitializeFirebase()
        {
            // No FirebaseAdmin initialization needed for this approach
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var signInData = new
                {
                    email,
                    password,
                    returnSecureToken = true
                };

                var json = JsonConvert.SerializeObject(signInData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (var client = new HttpClient())
                {
                    var response = await client.PostAsync(FirebaseSignInUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        // Parse the response JSON for user data
                        // Handle the successful sign-in here

                        MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide(); // In the LoginForm

                    }
                    else
                    {
                        var errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(await response.Content.ReadAsStringAsync());
                        MessageBox.Show("Login failed: " + errorResponse.error.message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // You can implement real-time input validation or feedback here.
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
