using System;
using System.Windows.Forms;

namespace Inventory_Managment_System.Dashboard
{
    public partial class DashboardView : UserControl
    {
        private DashboardController controller;

        public event EventHandler ProductManagementButtonClicked;
        public event EventHandler CheckoutButtonClicked;
        public event EventHandler BackButtonClicked;

        public DashboardView()
        {
            InitializeComponent();

            productMangementButton.Click += (sender, e) => ProductManagementButtonClicked?.Invoke(this, EventArgs.Empty);
            checkOutButton.Click += (sender, e) => CheckoutButtonClicked?.Invoke(this, EventArgs.Empty);
            backButton.Click += (sender, e) => BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void DashboardView_Load(object sender, EventArgs e)
        {

        }
    }
}
