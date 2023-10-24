using Google.Cloud.Firestore;
using Inventory_Management_System;
using Inventory_Managment_System.Checkout_Management;
using Inventory_Managment_System.Dashboard;
using Inventory_Managment_System.LogIn_Management;
using Inventory_Managment_System.ProductManagement;
using Inventory_Managment_System.Sales_Manager;
using Inventory_Managment_System.SignUp_Management;
using System;
using System.Windows.Forms;

namespace Inventory_Managment_System
{
    public partial class ApplicationManager : Form
    {
        private LoginView login;
        private LoginModel loginModel;
        private LoginController loginController;

        private SignUpView signUpView;
        private SignUpModel signUpModel;
        private SignUpController signUpController;
        FirestoreDb firestoreDb;


        private ProductManagementView productManagementView;
        private ProductController productController;

        private DashboardView DashboardView;
        private DashboardModel dashboardModel;
        private DashboardController dashboardController;


        ProductModel productModel;
        CheckoutView checkoutView;
        


        private const string FirebaseApiKey = "AIzaSyAz7GmkdHjccaWX8oogwq7rzmMMqI20Nc0";
        private const string FirebaseSignInUrl = "https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key=" + FirebaseApiKey;
        private const string FirebaseSignUpUrl = "https://identitytoolkit.googleapis.com/v1/accounts:signUp?key=" + FirebaseApiKey;



        public ApplicationManager()
        {
            InitializeComponent();
            firestoreDb = FirestoreDb.Create("inventory-management-sys-df9e8");
            this.WindowState = FormWindowState.Maximized;

            login = new LoginView();
            panel1.Controls.Add(login);

            signUpView = new SignUpView();
            panel1.Controls.Add(signUpView);

            DashboardView = new DashboardView();
            panel1.Controls.Add(DashboardView);


            productManagementView = new ProductManagementView();
            panel1.Controls.Add(productManagementView);

            checkoutView = new CheckoutView();
            panel1.Controls.Add(checkoutView);






        }
        public void InitiateLogin()
        {
            DashboardView.Visible = false;
            signUpView.Visible = false;
            login.Visible = true;


        }

        public void ProgramStart()
        {
            loginModel = new LoginModel();
            
            loginController = new LoginController(login, loginModel,this, FirebaseSignInUrl);
            panel1.Controls.Add(login);
            DashboardView.Visible = false;
            productManagementView.Visible = false;
            signUpView.Visible = false;
            checkoutView.Visible = false;
            login.Visible = true;
            
        }



        public void InitiateSignUp()
        {
            signUpModel = new SignUpModel();
            signUpController = new SignUpController(signUpView, signUpModel ,this, firestoreDb, FirebaseSignUpUrl);
           
            login.Visible = false;
            signUpView.Visible = true;
            





        }

       

        public void InitiateDashboardView(string IdToken)
        {
            productModel = new ProductModel(firestoreDb, IdToken);
            dashboardModel = new DashboardModel();
            dashboardController = new DashboardController(DashboardView, dashboardModel, this, IdToken,firestoreDb,productModel);
            productManagementView.Visible = false;
            checkoutView.Visible = false;
            login.Visible = false;
            DashboardView.Visible = true;



        }

        public void InitiateCheckout(string IDToken)
        {
            CheckoutModel checkout = new CheckoutModel(productModel, firestoreDb);
            CheckoutController checkoutController = new CheckoutController(checkout, checkoutView, this, IDToken);
            
            DashboardView.Visible = false;
            checkoutView.Visible = true; 
        }

        public void InitiateProductManager(string IDToken)
        {

           
           
            productController = new ProductController(firestoreDb, IDToken, productManagementView, this);
      
            DashboardView.Visible = false;
            productManagementView.Visible = true;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
