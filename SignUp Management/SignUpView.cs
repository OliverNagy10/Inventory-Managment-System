using Google.Cloud.Firestore;
using Inventory_Management_System;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace Inventory_Managment_System
{
    public partial class SignUpView : Form
    {
        public SignUpView()
        {
            InitializeComponent();
            InitializeFirebase();
        }

        public event EventHandler SignUpButtonClicked;
        public event EventHandler LogInButtonClicked;

        public string GetEmail()
        {
            return companyEmailBox.Text;
        }

        public string GetPassword()
        {
            return passwordBox.Text;
        }

        public string GetCompanyName()
        {
            return companyNameBox.Text;
        }

        public void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void InitializeFirebase()
        {
            // No FirebaseAdmin initialization needed for this approach
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUpButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            LogInButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
