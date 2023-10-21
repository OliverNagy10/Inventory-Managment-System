using System;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class LoginFormView : Form
    {
        // Event for the login button click
        public event EventHandler LoginButtonClicked;
        public event EventHandler SignUpButtonClicked;

        public LoginFormView()
        {
            InitializeComponent();
            
            // Attach the button click event to the controller's method
            logInButton.Click += (sender, e) => LoginButtonClicked?.Invoke(this, EventArgs.Empty);
            signUpButton.Click += (sender, e) => SignUpButtonClicked?.Invoke(this, EventArgs.Empty);
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

        private void LoginFormView_Load(object sender, EventArgs e)
        {

        }
    }
}
