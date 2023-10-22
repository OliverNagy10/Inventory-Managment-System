using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Managment_System.ProductManagement
{
    public partial class ProductManagementView : UserControl
    {
        // Event for the Add button click
        public event EventHandler AddButtonClicked;
        public event EventHandler SearchButtonClicked;
        public event EventHandler SaveButtonClicked;
        public event EventHandler DeleteButtonClicked;

        public ProductManagementView()
        {
            InitializeComponent();

            // Attach event handler for the Add button click
            addButton.Click += (sender, e) => AddButtonClicked?.Invoke(this, EventArgs.Empty);
            productScrollBar.ValueChanged += ProductScrollBar_ValueChanged;
            // Attach event handler for the Search button click
            searchButton.Click += (sender, e) => SearchButtonClicked?.Invoke(this, EventArgs.Empty);
            saveButton.Click += (sender, e) => SaveButtonClicked?.Invoke(this, EventArgs.Empty);
            deleteButton.Click += (sender, e) => DeleteButtonClicked?.Invoke(this, EventArgs.Empty);

        

       
    }

    // Methods to get input from the user
    public string GetName()
        {
            return nameBox.Text;
        }

        public int GetBarcode()
        {
            if (int.TryParse(barcodeBox.Text,out int barcode))
            {
                return barcode;
            }
            return 0; // Default value if parsing fails
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

        // Method to get the search query
        public string GetSearchQuery()
        {
            return SearchBox.Text;
        }

        // Method to get the search query
        public void SetBarCode(int barcode)
        {
            barcodeBox.Text = barcode.ToString();
        }

        // Methods to set values in the view
        public void SetName(string name)
        {
            nameBox.Text = name;
        }

        public void SetDescription(string description)
        {
            descriptionBox.Text = description;
        }

        public void SetSupplier(string supplier)
        {
            supplierBox.Text = supplier;
        }

        public void SetPrice(double price)
        {
            priceBox.Text = price.ToString();
        }

        public void SetQuantity(int quantity)
        {
            quantityBox.Text = quantity.ToString();
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
            // Any initialization code
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        public void ClearTextFields()
        {
            nameBox.Clear();
            descriptionBox.Clear();
            supplierBox.Clear();
            priceBox.Clear();
            quantityBox.Clear();
        }

        public void PopulateProductListView(List<string> productNames)
        {
            productListView.Items.Clear();

            foreach (var productName in productNames)
            {
                ListViewItem item = new ListViewItem(productName);
                productListView.Items.Add(item);
            }
        }

        private void ProductScrollBar_ValueChanged(object sender, EventArgs e)
        {
            if (productScrollBar.Value >= 0 && productScrollBar.Value < productListView.Items.Count)
            {
                productListView.TopItem = productListView.Items[productScrollBar.Value];
            }
        }

        private void ProductManagementView1_Load(object sender, EventArgs e)
        {

        }

        private void ProductManagementView_Load_1(object sender, EventArgs e)
        {

        }
    }
}
