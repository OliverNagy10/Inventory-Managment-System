using System;
using System.Windows.Forms;

namespace Inventory_Managment_System
{
    public partial class ProductManagementView : Form
    {
        // Event for the Add button click
        public event EventHandler AddButtonClicked;
        public event EventHandler SearchButtonClicked; // Add event for the Search button
        public event EventHandler SaveButtonClicked;

        public ProductManagementView()
        {
            InitializeComponent();

            // Attach event handler for the Add button click
            addButton.Click += (sender, e) => AddButtonClicked?.Invoke(this, EventArgs.Empty);

            // Attach event handler for the Search button click
            searchButton.Click += (sender, e) => SearchButtonClicked?.Invoke(this, EventArgs.Empty);
            saveButton.Click += (sender, e) => SaveButtonClicked?.Invoke(this, EventArgs.Empty);
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

        // Method to get the search query
        public string GetSearchQuery()
        {
            return SearchBox.Text;
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
    }
}
