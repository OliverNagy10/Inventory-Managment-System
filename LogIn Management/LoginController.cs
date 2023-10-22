using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Managment_System;
using Inventory_Managment_System.LogIn_Management;

namespace Inventory_Management_System
{
    public class LoginController
    {
        private LoginView view;
        private LoginModel model;
        private MainForm mainForm; // Add a field to store the MainForm instance


        public LoginController(LoginView view, LoginModel model,MainForm mainForm)
        {
            this.view = view;
            this.model = model;
            this.mainForm = mainForm; // Store the MainForm instance

            // Attach event handlers in the view
            view.LoginButtonClicked += async (sender, e) => await LoginButtonClickedAsync();
            view.SignUpButtonClicked += SignUpButtonClicked;
        }

        private async Task LoginButtonClickedAsync()
        {
            string email = view.GetEmail();
            string password = view.GetPassword();

            try
            {
                SignInResponse signInResponse = await model.SignInAsync(email, password);

                // Handle the successful sign-in here
                view.ShowSuccess("Login successful.");
                mainForm.InitiateDashboardView(signInResponse.idToken);
            }
            catch (Exception ex)
            {
                // Handle errors
                view.ShowError(ex.Message);
            }
        }

        private void SignUpButtonClicked(object sender, EventArgs e)
        {
           
            mainForm.InitiateSignUp();
        }
    }
}
