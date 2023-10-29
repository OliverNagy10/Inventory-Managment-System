using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Managment_System.SignUp_Management
{
    public partial class SignUpView : UserControl
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

        

        private void SignUpView1_Load(object sender, EventArgs e)
        {

        }

        private void SignUpView_Load(object sender, EventArgs e)
        {

        }
    }
}
