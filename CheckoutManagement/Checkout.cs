using Inventory_Managment_System.Sales_Manager;
using System;
using System.Windows.Forms;

namespace Inventory_Managment_System
{
    public partial class Checkout : UserControl
    {
       
        private SalesManager salesManager;
        public Checkout(SalesManager manager)
        {
            InitializeComponent();
            salesManager = manager;
        }
        private async void addItemButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(nameTextBox.Text, out int productBarcode))
            {
                int quantity = 1; // You can add quantity input in the UI if needed.

                await salesManager.AddToBasketAsync(productBarcode, quantity);

                // Update the basketListView
                UpdateBasketListView();
            }
            else
            {
                // Handle the case where the input is not a valid integer.
                // You might want to display an error message to the user.
                MessageBox.Show("Invalid product barcode. Please enter a valid number.");
            }
        }

        private void removeFromBasketButton_Click(object sender, EventArgs e)
        {
            // Get the selected item in the basketListView
            if (basketListView.SelectedItems.Count > 0)
            {
                string productName = basketListView.SelectedItems[0].Text;

                // Remove the item from the basket
                salesManager.RemoveFromBasket(productName);

                // Update the basketListView
                UpdateBasketListView();
            }
        }
        private void UpdateBasketListView()
        {
            // Clear the current list view items
            basketListView.Items.Clear();

            // Add items from the sales manager's basket
            foreach (var product in salesManager.basket)
            {
                ListViewItem listViewItem = new ListViewItem(product.Name); // Column 1: Name
                listViewItem.SubItems.Add(product.Description); // Column 2: Description
                listViewItem.SubItems.Add(product.Quantity.ToString()); // Column 3: Quantity
                listViewItem.SubItems.Add(product.Price.ToString()); // Column 4: Price
                listViewItem.SubItems.Add(product.Barcode.ToString()); // Column 5: Barcode

                basketListView.Items.Add(listViewItem);
            }

            // Update the total amount
            AmountHolderLabel.Text = salesManager.CalculateTotalPrice().ToString();
        }




        private void Checkout_Load(object sender, EventArgs e)
        {
            // Set the View property of the basketListView to Details
            basketListView.View = View.Details;
            // Set up the columns for the basketListView
            basketListView.Columns.Add("Name", 200); // Column 1: Name
            basketListView.Columns.Add("Description", 200); // Column 2: Description
            basketListView.Columns.Add("Quantity", 100); // Column 3: Quantity
            basketListView.Columns.Add("Price", 100); // Column 4: Price
            basketListView.Columns.Add("Barcode", 100); // Column 5: Barcode

        }

        private async void checkoutButton_ClickAsync(object sender, EventArgs e)
        {
            // Check if the basket is not empty
            if (salesManager.basket.Count > 0)
            {
                // Call the CheckoutAsync method in your SalesManager to create a sale record and add it to the database
                await salesManager.CheckoutAsync();

                // Clear the basketListView
                basketListView.Items.Clear();

                // Update the total amount label
                AmountHolderLabel.Text = "0.00";
            }
            else
            {
                // Handle the case where the basket is empty.
                // You might want to display a message to the user.
                MessageBox.Show("The basket is empty. Please add items before checking out.");
            }
        }


        private void PayPalLoginButton_Click(object sender, EventArgs e)
        {
            // Navigate to the PayPal login page when the form loads
            webBrowser1.Navigate(new Uri($"https://www.paypal.com/signin/authorize?response_type=code&client_id={ClientId}&redirect_uri={RedirectUri}&scope=openid"));
        }

       
        }
        
    }



