using Inventory_Managment_System;
using Inventory_Managment_System.SignUp_Management;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public class SignUpController
    {
        private SignUpView view;
        private SignUpModel model;

        public SignUpController(SignUpView view, SignUpModel model)
        {
            this.view = view;
            this.model = model;

            // Attach event handlers in the view
            view.SignUpButtonClicked += async (sender, e) => await SignUpButtonClickedAsync();
            view.LogInButtonClicked += LogInButtonClicked;
        }

        private async Task SignUpButtonClickedAsync()
        {
            string email = view.GetEmail();
            string password = view.GetPassword();
            string companyName = view.GetCompanyName();

            try
            {
                SignInResponse signUpResponse = await model.SignUpAsync(email, password,companyName);

                // Handle the successful sign-up here
                view.ShowSuccess("Sign-up successful.");

                // Proceed with additional actions, e.g., opening the login form or other actions.

                // Note: You may want to add the user to your Firestore database at this point.

            }
            catch (Exception ex)
            {
                // Handle errors
                view.ShowError(ex.Message);
            }
        }

        private void LogInButtonClicked(object sender, EventArgs e)
        {
            // Show the Login form
            
        }
    }
}
