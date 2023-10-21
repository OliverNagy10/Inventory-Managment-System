using System;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text;

namespace Inventory_Managment_System
{
    public partial class ProductManagementView : Form
    {
        // Event for the Add button click
        public event EventHandler AddButtonClicked;

        public ProductManagementView()
        {
            InitializeComponent();
            

         
        }

        // Methods to get input from the user
        public string GetName()
        {
            return nameBox.Text;
        }

        public string GetDescription()
        {
            return descriptionBox.Text;
        }

        public string GetSupplier()
        {
            return supplierBox.Text;
        }

        public double GetPrice()
        {
            if (double.TryParse(priceBox.Text, out double price))
            {
                return price;
            }
            return 0.0; // Default value if parsing fails
        }

        public int GetQuantity()
        {
            if (int.TryParse(quantityBox.Text, out int quantity))
            {
                return quantity;
            }
            return 0; // Default value if parsing fails
        }

        public void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ProductManagementView_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddButtonClicked?.Invoke(this, EventArgs.Empty);

        }
    }
}
