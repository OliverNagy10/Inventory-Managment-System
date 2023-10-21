using Google.Cloud.Firestore;
using Inventory_Management_System;
using Inventory_Managment_System.LogIn_Management;
using Inventory_Managment_System.SignUp_Management;
using System;
using System.Windows.Forms;

namespace Inventory_Managment_System
{
    public partial class MainForm : Form
    {
        private LoginView login;
        private LoginModel loginModel;
        private LoginController loginController;

        private SignUpView signUp;
        private SignUpModel signUpModel;
        private SignUpController signUpController;
        


        public MainForm()
        {
            InitializeComponent();



            
            
        }

        public void InitiateLogin()
        {
            loginModel = new LoginModel();
            login = new LoginView();
            loginController = new LoginController(login, loginModel,this);
            // Add the LoginView to the panel
            panel1.Controls.Add(login);
            login.Visible = true;
        }

        public void InitiateSignUp()
        {
            signUpModel = new SignUpModel();
            signUp = new SignUpView();
            signUpController = new SignUpController(signUp, signUpModel);
            panel1.Controls.Add(signUp);
            login.Visible = false;
            signUp.Visible = true;
            





        }

        public void InitiateProductManager(string IDToken)
        {

            FirestoreDb firestoreDb = FirestoreDb.Create("inventory-management-sys-df9e8");
            ProductManagementView pm = new ProductManagementView();
            ProductController controller = new ProductController(firestoreDb, IDToken, pm);
            pm.Show();
            this.Hide();
        } 

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
