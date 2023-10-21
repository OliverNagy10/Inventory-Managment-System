using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Managment_System;

namespace Inventory_Management_System
{
    public class LoginController
    {
        private LoginFormView view;
        private LoginModel model;

       
        public LoginController(LoginFormView view, LoginModel model)
        {
            this.view = view;
            this.model = model;

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

                // Navigate to the Dashboard with the ID token
                Dashboard dashboard = new Dashboard(signInResponse.idToken);
                dashboard.Show();
                view.Hide(); // Hide the LoginForm
            }
            catch (Exception ex)
            {
                // Handle errors
                view.ShowError(ex.Message);
            }
        }

        private void SignUpButtonClicked(object sender, EventArgs e)
        {
            // Show the Login form
            view.Hide(); // Hide the SignUp form
            SignUpView signUpForm = new SignUpView();
            SignUpModel signUpModel = new SignUpModel();
            SignUpController signUpController = new SignUpController(signUpForm, signUpModel);
            signUpForm.Show();
        }
    }
}
