using System;

namespace Inventory_Managment_System.Dashboard
{
    public class DashboardController
    {
        private DashboardView view;
        private DashboardModel model;
        private MainForm mainForm;
        private string IDToken;

        public DashboardController(DashboardView view, DashboardModel model, MainForm mainForm, string IDToken)
        {
            this.view = view;
            this.model = model;
            this.mainForm = mainForm;
            this.IDToken = IDToken;

            // Attach event handlers to the events in the view
            view.ProductManagementButtonClicked += (sender, args) => OnProductManagementButtonClick();
            view.CheckoutButtonClicked += (sender, args) => OnCheckoutButtonClick();
            view.BackButtonClicked += (sender, args) => OnBackButtonClick();
        }

        public void OnProductManagementButtonClick()
        {
            // Handle the product management button click event
            mainForm.InitiateProductManager(IDToken);
        }

        public void OnCheckoutButtonClick()
        {
            // Handle the checkout button click event
            mainForm.InitiateCheckout(IDToken);
        }

        public void OnBackButtonClick()
        {
            // Handle the back button click event
            mainForm.InitiateLogin();
        }

        // Add other controller methods as needed to handle user interactions
    }
}
