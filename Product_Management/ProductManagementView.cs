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

        public event EventHandler AddButtonClicked;
        public event EventHandler SearchButtonClicked;
        public event EventHandler SaveButtonClicked;
        public event EventHandler DeleteButtonClicked;
        public event EventHandler<string> ListViewItemSelectionChanged;
        public event EventHandler BackButtonClicked;


        public ProductManagementView()
        {
            InitializeComponent();

            // Attach event handler for the Add button click
            addButton.Click += (sender, e) => AddButtonClicked?.Invoke(this, EventArgs.Empty);
        
            // Attach event handler for the Search button click
            searchButton.Click += (sender, e) => SearchButtonClicked?.Invoke(this, EventArgs.Empty);
            saveButton.Click += (sender, e) => SaveButtonClicked?.Invoke(this, EventArgs.Empty);
            deleteButton.Click += (sender, e) => DeleteButtonClicked?.Invoke(this, EventArgs.Empty);
            backButton.Click += (sender, e) => BackButtonClicked?.Invoke(this, EventArgs.Empty);




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
        public void SetSearchQuery(string name)
        {
            SearchBox.Text = name;

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
            // Set the View property of the productListView to Details
            productListView.View = View.Details;
            // Set up the columns for the productListView
            productListView.Columns.Add("Name", 200); // Column 1: Name
            productListView.Columns.Add("Description", 200); // Column 2: Description
            productListView.Columns.Add("Supplier", 200); // Column 1: Name
            productListView.Columns.Add("Quantity", 100); // Column 3: Quantity
            productListView.Columns.Add("Price", 100); // Column 4: Price
            productListView.Columns.Add("Barcode", 100); // Column 5: Barcode
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

        private void BackButton_Click(object sender, EventArgs e)
        {
           BackButtonClicked?.Invoke(this, EventArgs.Empty);
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

            // Attach an event handler to handle item selection change
            productListView.SelectedIndexChanged += (sender, e) =>
            {
                if (productListView.SelectedItems.Count > 0)
                {
                    var selectedItem = productListView.SelectedItems[0];
                    // Trigger the ListViewItemSelectionChanged event with the selected product name
                    ListViewItemSelectionChanged?.Invoke(this, selectedItem.Text);
                }
            };
        }

        public void UpdateProductListView(List<object> products)
        {
            productListView.Items.Clear();

            foreach (var product in products)
            {
                var productDetails = (dynamic)product;
                ListViewItem item = new ListViewItem(productDetails.Name);
                item.SubItems.Add(productDetails.Description); // Description
                item.SubItems.Add(productDetails.Supplier); // Supplier
                item.SubItems.Add(productDetails.Quantity.ToString()); // Quantity
                item.SubItems.Add(productDetails.Price.ToString()); // Price
                item.SubItems.Add(productDetails.Barcode.ToString()); // Barcode
                                                                    

                productListView.Items.Add(item);
            }

            Console.WriteLine("Successfully updated product list view in the view.");
        }




        private void ProductManagementView_Load_1(object sender, EventArgs e)
        {

        }
    }
}
