using Inventory_Managment_System.Checkout_Management;
using Inventory_Managment_System.Sales_Manager;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Managment_System
{
    public partial class CheckoutController 
    {

        private CheckoutModel CheckoutModel;
        public event EventHandler ExitButtonClicked;
        private CheckoutView checkoutView;
        private MainForm mainform;
        private string IDToken;

        public CheckoutController(CheckoutModel model, CheckoutView checkoutView, MainForm mainform , string IDToken)
        {
            this.CheckoutModel = model;
            this.checkoutView = checkoutView;
            this.mainform = mainform;
            this.IDToken = IDToken;
            
            checkoutView.AddItemButtonClicked += async (sender, args) => await addItemToBasket();
            checkoutView.DeleteItemButtonClicked += async (sender, args) => await RemoveFromBasket();
            checkoutView.PayWithCardClicked += async (sender, args) => await checkoutWithCardAsync();
            checkoutView.PaywithCashClicked += async (sender, args) => await CheckoutWithCashAsync();
            checkoutView.ExitButtonClicked += (sender, args) => Exit();



        }
        private async Task addItemToBasket()
        {
         
                int quantity = 1; // You can add quantity input in the UI if needed.

                await CheckoutModel.AddToBasketAsync(checkoutView.GetProductBarcode(), quantity);

            // Update the basketListView
            await UpdateBasketListView();

            
        }

        private async Task RemoveFromBasket()
        {
            // Get the selected item in the basketListView

             CheckoutModel.RemoveFromBasket(checkoutView.getRemovefromBasket());

            // Update the basketListView
            await UpdateBasketListView();
            
        }

        private  Task UpdateBasketListView()
        {
            checkoutView.UpdateBasketListView(CheckoutModel);
            return Task.CompletedTask;
        }

        private async Task checkoutWithCardAsync()
        {

            await CheckoutModel.CheckoutWithCardAsync();
        }


        private async Task CheckoutWithCashAsync()
        {
            // Check if the basket is not empty
            if (CheckoutModel.basket.Count > 0)
            {
                // Call the CheckoutAsync method in your CheckoutModel to create a sale record and add it to the database
                await CheckoutModel.CheckoutAsync();

                // Clear the basketListView
                checkoutView.ClearBasket();

                // Update the total amount label
                checkoutView.SetAmountHolder("0.0");
            }
            else
            {
                // Handle the case where the basket is empty.
                // You might want to display a message to the user.
                MessageBox.Show("The basket is empty. Please add items before checking out.");
            }
        }

        private void Exit()
        {
            mainform.InitiateDashboardView(IDToken);

        }

        private void CheckoutView_Load(object sender, EventArgs e)
        {

        }
    }

}
