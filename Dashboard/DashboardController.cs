using System;
using System.Collections.Generic;
using Google.Cloud.Firestore;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Dashboard
{
    public class DashboardController
    {
        private DashboardView view;
        private DashboardModel model;
        private MainForm mainForm;
        private string IDToken;
        private FirestoreDb db; // Firestore database reference
        ProductModel  productModel;

        public  DashboardController(DashboardView view, DashboardModel model, MainForm mainForm, string IDToken, FirestoreDb firestoreDb , ProductModel productModel)
        {
            this.view = view;
            this.model = model;
            this.mainForm = mainForm;
            this.IDToken = IDToken;
            this.productModel = productModel;
            this.db = firestoreDb; // Initialize Firestore database reference

            // Attach event handlers to the events in the view
            view.ProductManagementButtonClicked += (sender, args) => OnProductManagementButtonClick();
            view.CheckoutButtonClicked += (sender, args) => OnCheckoutButtonClick();
            view.BackButtonClicked += (sender, args) => OnBackButtonClick();

            // Load and display inventory value and total sales
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            // Load and display inventory value and total sales
            await UpdateInventoryValueAndTotalSales();
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

        public async Task UpdateInventoryValueAndTotalSales()
        {
            try
            {
                // Calculate the total sales and inventory value
                double totalInventoryValue = await CalculateTotalInventoryValue();
                double totalSales = await CalculateTotalSalesThisMonth();
                

                // Debug statements
                Console.WriteLine("Total Sales: " + totalSales);
                Console.WriteLine("Total Inventory Value: " + totalInventoryValue);

                // Update the view
                view.UpdateInventoryValue(totalInventoryValue);
                view.UpdateTotalSales(totalSales);
            }
            catch (Exception ex)
            {
                // Handle exceptions and errors
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }


        // Add other controller methods as needed to handle user interactions

        public async Task<double> CalculateTotalSalesThisMonth()
        {
            // Get the currently authenticated user's ID
            string userId = await productModel.GetUserIdFromFirebaseAuthenticationAsync();
            try
            {
                // Calculate the start and end dates of the current month
                DateTime today = DateTime.UtcNow;
                DateTime startDate = new DateTime(today.Year, today.Month, 1, 0, 0, 0, DateTimeKind.Utc);
                DateTime endDate = startDate.AddMonths(1);

                // Get a reference to the company's document in the "companies" collection
                DocumentReference companyRef = db.Collection("companies").Document(userId);

                // Get a reference to the "sales" collection within the company's document
                CollectionReference salesCollection = companyRef.Collection("sales");

                // Query for sales records within the current month
                QuerySnapshot querySnapshot = await salesCollection
                    .WhereGreaterThanOrEqualTo("Date", startDate)
                    .WhereLessThan("Date", endDate)
                    .GetSnapshotAsync();

                double totalSales = 0.0;

                foreach (var documentSnapshot in querySnapshot)
                {
                    if (documentSnapshot.Exists)
                    {
                        // Extract the TotalSalePrice field and add it to the total
                        var saleData = documentSnapshot.ToDictionary();
                        if (saleData.ContainsKey("TotalSalePrice") && saleData["TotalSalePrice"] is double salePrice)
                        {
                            totalSales += salePrice;
                        }
                    }
                }

                return totalSales;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred: " + ex.Message);
            }
        }

        public async Task<double> CalculateTotalInventoryValue()
        {
            // Get the currently authenticated user's ID
            string userId = await productModel.GetUserIdFromFirebaseAuthenticationAsync();

            try
            {
                if (userId == null)
                {
                    Console.WriteLine("User is not authenticated.");
                    return 0.0; // Return a default value or handle the unauthenticated user case as needed
                }

                // Get a reference to the company's document in the "companies" collection
                DocumentReference companyRef = db.Collection("companies").Document(userId);

                // Get a reference to the "products" collection within the company's document
                CollectionReference productsCollection = companyRef.Collection("products");

                // Query for all product records
                QuerySnapshot querySnapshot = await productsCollection.GetSnapshotAsync();

                Console.WriteLine($"Found {querySnapshot.Count} products in the collection."); // Debug: Output the number of products found

                double totalValue = 0.0;

                foreach (var documentSnapshot in querySnapshot)
                {
                    if (documentSnapshot.Exists)
                    {
                        var productData = documentSnapshot.ToDictionary();

                        if (productData.ContainsKey("Price") && productData["Price"] is double price)
                        {
                            if (productData.ContainsKey("Quantity"))
                            {
                                // Try to parse the "Quantity" field as an integer
                                if (int.TryParse(productData["Quantity"].ToString(), out int quantity))
                                {
                                    double productValue = price * quantity;
                                    totalValue += productValue;

                                    // Debug statement: Output the product name, price, quantity, and calculated value
                                    string productName = documentSnapshot.Id;
                                    Console.WriteLine($"Product: {productName}, Price: {price}, Quantity: {quantity}, Value: {productValue}");
                                }
                                else
                                {
                                    Console.WriteLine($"Product {documentSnapshot.Id} has a non-integer Quantity value.");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Product {documentSnapshot.Id} is missing the Quantity field.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Product {documentSnapshot.Id} has a non-double Price value.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Product {documentSnapshot.Id} does not exist in Firestore.");
                    }
                }


                Console.WriteLine($"Total Value of Inventory: {totalValue}");
                return totalValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                // Handle the error or return a default value if necessary
                return 0.0;
            }
        }




    }
}
