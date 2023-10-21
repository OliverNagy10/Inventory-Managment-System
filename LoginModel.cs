using Inventory_Managment_System;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    public class LoginModel
    {
        private const string FirebaseApiKey = "AIzaSyAz7GmkdHjccaWX8oogwq7rzmMMqI20Nc0";
        private const string FirebaseSignInUrl = "https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key=" + FirebaseApiKey;

        public async Task<SignInResponse> SignInAsync(string email, string password)
        {
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
                        return JsonConvert.DeserializeObject<SignInResponse>(responseContent);
                    }
                    else
                    {
                        var errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(await response.Content.ReadAsStringAsync());
                        throw new Exception("Login failed: " + errorResponse.error.message);
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
