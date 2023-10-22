using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Managment_System.LogIn_Management
{
    public partial class LoginView : UserControl
    {
        // Event for the login button click
        public event EventHandler LoginButtonClicked;
        public event EventHandler SignUpButtonClicked;
        // Define your TableLayoutPanel and other controls.
      


        public LoginView()
        {
            InitializeComponent();

            // Attach the button click event to the controller's method
            logInButton.Click += (sender, e) => LoginButtonClicked?.Invoke(this, EventArgs.Empty);
            signUpButton.Click += (sender, e) => SignUpButtonClicked?.Invoke(this, EventArgs.Empty);
            // Center the controls in the panel
       



        }

        // Existing code for InitializeFirebase, button1_Click, and SignUpClick methods

        // Methods to get user input
        public string GetEmail()
        {
            return textBox1.Text;
        }

        public string GetPassword()
        {
            return textBox2.Text;
        }

        public void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            // Calculate the center position based on the form's size
           

        }

        private void LoginView_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
