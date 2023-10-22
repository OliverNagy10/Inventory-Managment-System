using Google.Cloud.Firestore;
using Inventory_Management_System;
using Inventory_Managment_System.Dashboard;
using Inventory_Managment_System.LogIn_Management;
using Inventory_Managment_System.ProductManagement;
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


        private ProductManagementView productManagementView;
        private ProductController productController;

        private DashboardView DashboardView;
        


        public MainForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;





        }
        public void InitiateLogin()
        {
            loginModel = new LoginModel();
            login = new LoginView();
            loginController = new LoginController(login, loginModel, this);
            // Add the LoginView to the panel
            panel1.Controls.Add(login);
            signUp.Visible = false;
            
            login.Visible = true;


        }

        public void ProgramStart()
        {
            loginModel = new LoginModel();
            login = new LoginView();
            loginController = new LoginController(login, loginModel,this);
            panel1.Controls.Add(login);
           
            login.Visible = true;
            
        }



        public void InitiateSignUp()
        {
            signUpModel = new SignUpModel();
            signUp = new SignUpView();
            signUpController = new SignUpController(signUp, signUpModel ,this);
            panel1.Controls.Add(signUp);
            login.Visible = false;
            signUp.Visible = true;
            





        }

        public void InitiateDashboardView(string IdToken)
        {
            // Navigate to the DashboardView with the ID token
            DashboardView = new DashboardView(IdToken, this);
            panel1.Controls.Add(DashboardView);
            login.Visible = false;
           
            DashboardView.Visible = true;



        }

        public void InitiateProductManager(string IDToken)
        {

            FirestoreDb firestoreDb = FirestoreDb.Create("inventory-management-sys-df9e8");
            productManagementView = new ProductManagementView();
            productController = new ProductController(firestoreDb, IDToken, productManagementView, this);
            panel1.Controls.Add(productManagementView);
            DashboardView.Visible = false;
            productManagementView.Visible = true;


        } 

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
