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
            string productName = nameTextBox.Text;
            int quantity = 1; // You can add quantity input in the UI if needed.

            await salesManager.AddToBasketAsync(productName, quantity);

            // Update the basketListView
            UpdateBasketListView();
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
                ListViewItem listViewItem = new ListViewItem(product.Name); // Assuming "Name" is the property in your Product class for the product name.
                listViewItem.SubItems.Add(product.Description); // Assuming "Description" is the property in your Product class for the product description.
                listViewItem.SubItems.Add(product.Quantity.ToString());
                listViewItem.SubItems.Add(product.Price.ToString());

                basketListView.Items.Add(listViewItem);
            }

            // Update the total amount
            AmountHolderLabel.Text = salesManager.CalculateTotalPrice().ToString();
        }



        private void Checkout_Load(object sender, EventArgs e)
        {

        }
    }
}
