using Inventory_Managment_System.Sales_Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Managment_System.Checkout_Management
{
    public partial class CheckoutView : UserControl
    {
        public event EventHandler AddItemButtonClicked;
        public event EventHandler PayWithCardClicked;
        public event EventHandler PaywithCashClicked;
        public event EventHandler DeleteItemButtonClicked;
        public event EventHandler ExitButtonClicked;

        public CheckoutView()
        {
            InitializeComponent();

            addItemButton.Click += (sender, e) => AddItemButtonClicked?.Invoke(this, EventArgs.Empty);
            payWithCardButton.Click += (sender, e) => PayWithCardClicked?.Invoke(this, EventArgs.Empty);
            payWithCashButton.Click += (sender, e) => PaywithCashClicked?.Invoke(this, EventArgs.Empty);
            exitButton.Click += (sender, e) => ExitButtonClicked?.Invoke(this, EventArgs.Empty);
            removeFromBasketButtom.Click += (sender, e) => DeleteItemButtonClicked?.Invoke(this, EventArgs.Empty);

        }

        public int GetProductBarcode()
        {
            if (int.TryParse(nameTextBox.Text, out int productBarcode))
            {
                return productBarcode;
            }
            else
            {
                // Handle the case where the input is not a valid integer. You might want to display an error message to the user.
                MessageBox.Show("Invalid product barcode. Please enter a valid number.");
                return 0; // Or some default value, depending on your requirements.
            }
        }
        public void ClearBasket() { 
        // Clear the current list view items
        basketListView.Items.Clear();
            }

        private void CheckoutView_Load(object sender, EventArgs e)
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

        public void SetAmountHolder(string number)
        {
            AmountHolderLabel.Text = number;

        }
        public string getRemovefromBasket()
        {
            if (basketListView.SelectedItems.Count > 0)
            {
                string productName = basketListView.SelectedItems[0].Text;
                return productName;

            }
            else
            {
                return null;
            }
        }


        public void UpdateBasketListView(CheckoutModel model)
        {

            ClearBasket();
            // Add items from the sales manager's basket
            foreach (var product in model.basket)
            {
                ListViewItem listViewItem = new ListViewItem(product.Name); // Column 1: Name
                listViewItem.SubItems.Add(product.Description); // Column 2: Description
                listViewItem.SubItems.Add(product.Quantity.ToString()); // Column 3: Quantity
                listViewItem.SubItems.Add(product.Price.ToString()); // Column 4: Price
                listViewItem.SubItems.Add(product.Barcode.ToString()); // Column 5: Barcode

                basketListView.Items.Add(listViewItem);
            }

            // Update the total amount
            SetAmountHolder(model.CalculateTotalPrice().ToString());
        }

       

        
                private void addButton_Click(object sender, EventArgs e)
                {
                    AddItemButtonClicked?.Invoke(this, EventArgs.Empty);
                }


    }
}
