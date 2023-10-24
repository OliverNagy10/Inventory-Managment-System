using System;
using System.Collections.Generic;
using Google.Cloud.Firestore;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;

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
            await UpdateDashboard();
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

        public async Task UpdateDashboard()
        {
            try
            {
                // Show the loading message
                view.ShowLoadingMessage(true);

                // Calculate the total sales and inventory value
                double totalInventoryValue = await CalculateTotalInventoryValue();
                double totalSales = await CalculateTotalSalesThisMonth();

                // Debug statements
                Console.WriteLine("Total Sales: " + totalSales);
                Console.WriteLine("Total Inventory Value: " + totalInventoryValue);

                // Update the view
                view.UpdateInventoryValue(totalInventoryValue);
                view.UpdateTotalSales(totalSales);
                // Call GetRunningLowProducts with your desired threshold
                int thresholdQuantity = 10; // Change this to your desired threshold
                await GetRunningLowProducts(thresholdQuantity);
                await CalculateSalesByDay();
                await CalculateBestSellers();
                await CalculateBestSellersByCashValue();
            }
            catch (Exception ex)
            {
                // Handle exceptions and errors
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                // Hide the loading message when all tasks are done
                view.ShowLoadingMessage(false);
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

        // ... (other code)

        public async Task GetRunningLowProducts(int thresholdQuantity)
        {
            try
            {
                // Get the currently authenticated user's ID
                string userId = await productModel.GetUserIdFromFirebaseAuthenticationAsync();

                if (userId == null)
                {
                    // Handle the unauthenticated user case as needed
                    return;
                }

                // Get a reference to the company's document in the "companies" collection
                DocumentReference companyRef = db.Collection("companies").Document(userId);

                // Get a reference to the "products" collection within the company's document
                CollectionReference productsCollection = companyRef.Collection("products");

                // Query for product records with Quantity less than the threshold
                QuerySnapshot querySnapshot = await productsCollection
                    .WhereLessThan("Quantity", thresholdQuantity)
                    .GetSnapshotAsync();

                // Create a list to store items for the ListView
                List<ListViewItem> listViewItems = new List<ListViewItem>();

                foreach (var documentSnapshot in querySnapshot)
                {
                    if (documentSnapshot.Exists)
                    {
                        var productData = documentSnapshot.ToDictionary();

                        if (productData.ContainsKey("Name") && productData.ContainsKey("Quantity"))
                        {
                            string productName = productData["Name"].ToString();
                            int quantity = int.Parse(productData["Quantity"].ToString());

                            // Create a ListViewItem to add to the ListView
                            var listViewItem = new ListViewItem(new[] { productName, quantity.ToString() });
                            listViewItems.Add(listViewItem);
                        }
                    }
                }

                // Update the view's ListView with the low products
                view.UpdateLowProductsListView(listViewItems);
            }
            catch (Exception ex)
            {
                // Handle the error or return a default value if necessary
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        // ... (other code)

        public async Task CalculateSalesByDay()
        {
            try
            {
                // Get the currently authenticated user's ID
                string userId = await productModel.GetUserIdFromFirebaseAuthenticationAsync();

                if (userId == null)
                {
                    // Handle the unauthenticated user case as needed
                    return;
                }

                // Get a reference to the company's document in the "companies" collection
                DocumentReference companyRef = db.Collection("companies").Document(userId);

                // Get a reference to the "sales" collection within the company's document
                CollectionReference salesCollection = companyRef.Collection("sales");

                // Calculate the start and end dates for the current week
                DateTime today = DateTime.UtcNow;
                DateTime startDate = today.Date.AddDays(-(int)today.DayOfWeek);
                DateTime endDate = startDate.AddDays(7);

                // Initialize an array to store sales for each day
                double[] dailySales = new double[7];

                // Query for sales records within the current week
                QuerySnapshot querySnapshot = await salesCollection
                    .WhereGreaterThanOrEqualTo("Date", startDate)
                    .WhereLessThan("Date", endDate)
                    .GetSnapshotAsync();

                foreach (var documentSnapshot in querySnapshot)
                {
                    if (documentSnapshot.Exists)
                    {
                        // Extract the Sale Date and Total Sale Price fields
                        var saleData = documentSnapshot.ToDictionary();
                        if (saleData.ContainsKey("Date") && saleData["Date"] is Timestamp saleDate
                            && saleData.ContainsKey("TotalSalePrice") && saleData["TotalSalePrice"] is double salePrice)
                        {
                            // Calculate the day of the week (0 = Sunday, 1 = Monday, ..., 6 = Saturday)
                            int dayOfWeek = (int)saleDate.ToDateTime().DayOfWeek;

                            // Add the sale to the appropriate day
                            dailySales[dayOfWeek] += salePrice;
                        }
                    }
                }

                // Create a series for the line chart
                Series series = new Series("Weekly Sales by Day");
                series.ChartType = SeriesChartType.Line;

                // Add data points to the series for each day
                for (int i = 0; i < dailySales.Length; i++)
                {
                    series.Points.AddXY(startDate.AddDays(i).ToString("ddd"), dailySales[i]);
                }

                // Update the line chart in the view
                view.UpdateLineChartSales(series);
            }
            catch (Exception ex)
            {
                // Handle the error or return a default value if necessary
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public async Task CalculateBestSellers()
        {
            try
            {
                Console.WriteLine("Entering CalculateBestSellers method.");

                // Get the currently authenticated user's ID
                string userId = await productModel.GetUserIdFromFirebaseAuthenticationAsync();
                Console.WriteLine($"User ID: {userId}");

                if (userId == null)
                {
                    // Handle the unauthenticated user case as needed
                    Console.WriteLine("User is not authenticated.");
                    return;
                }

                // Get a reference to the company's document in the "companies" collection
                DocumentReference companyRef = db.Collection("companies").Document(userId);
                Console.WriteLine("Retrieved company reference.");

                // Get a reference to the "sales" collection within the company's document
                CollectionReference salesCollection = companyRef.Collection("sales");
                Console.WriteLine("Retrieved sales collection reference.");

                // Calculate the start and end dates for the current month
                DateTime today = DateTime.UtcNow;
                DateTime startDate = new DateTime(today.Year, today.Month, 1, 0, 0, 0, DateTimeKind.Utc);
                DateTime endDate = startDate.AddMonths(1);
                Console.WriteLine($"Start Date: {startDate}, End Date: {endDate}");

                Dictionary<string, int> productSales = new Dictionary<string, int>();

                // Query for sales records within the current month
                QuerySnapshot querySnapshot = await salesCollection
                    .WhereGreaterThanOrEqualTo("Date", startDate)
                    .WhereLessThan("Date", endDate)
                    .GetSnapshotAsync();
                

                foreach (var salesDocument in querySnapshot)
                {
                    // Get the "items" subcollection within each sales document
                    CollectionReference itemsCollection = salesDocument.Reference.Collection("items");

                    // Iterate through items within the "items" subcollection
                    QuerySnapshot itemsSnapshot = await itemsCollection.GetSnapshotAsync();

                    foreach (var itemDocument in itemsSnapshot)
                    {
                        if (itemDocument.Exists)
                        {
                            // Extract the "Name" and "Quantity" fields
                            var itemData = itemDocument.ToDictionary();
                            Console.WriteLine("Extracted item data: " + string.Join(", ", itemData.Select(kvp => $"{kvp.Key}: {kvp.Value}")));

                            if (itemData.ContainsKey("Name") && itemData["Name"] is string itemName)
                            {
                                // Retrieve the "Quantity" as described
                                if (itemData.ContainsKey("Quantity") && int.TryParse(itemData["Quantity"].ToString(), out int quantity))
                                {
                                    // If the item is not in the dictionary, add it with the sold quantity
                                    if (!productSales.ContainsKey(itemName))
                                    {
                                        productSales[itemName] = quantity;
                                    }
                                    else
                                    {
                                        // Otherwise, update the sold quantity
                                        productSales[itemName] += quantity;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"Item {itemName} has a non-integer Quantity value.");
                                }
                            }
                        }
                    }
                }

                // Sort the products by sales quantity in descending order
                var topSellers = productSales.OrderByDescending(x => x.Value).Take(3);
                Console.WriteLine("Top Sellers:");

                foreach (var seller in topSellers)
                {
                    Console.WriteLine($"{seller.Key}: {seller.Value}");
                }

                // Create a series for the pie chart
                Series series = new Series("Top 3 Sellers This Month")
                {
                    ChartType = SeriesChartType.Pie
                };
                Console.WriteLine("Created pie chart series.");

                // Add data points to the series for each top seller
                foreach (var seller in topSellers)
                {
                    series.Points.AddXY(seller.Key, seller.Value);
                }

                Console.WriteLine("Added data points to the pie chart series.");

                // Update the pie chart in the view
                view.UpdatePieChartBestSellers(series);
            }
            catch (Exception ex)
            {
                // Handle the error or return a default value if necessary
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public async Task CalculateBestSellersByCashValue()
        {
            try
            {
                Console.WriteLine("Entering CalculateBestSellersByCashValue method.");

                // Get the currently authenticated user's ID
                string userId = await productModel.GetUserIdFromFirebaseAuthenticationAsync();
                Console.WriteLine($"User ID: {userId}");

                if (userId == null)
                {
                    // Handle the unauthenticated user case as needed
                    Console.WriteLine("User is not authenticated.");
                    return;
                }

                // Get a reference to the company's document in the "companies" collection
                DocumentReference companyRef = db.Collection("companies").Document(userId);
                Console.WriteLine("Retrieved company reference.");

                // Get a reference to the "sales" collection within the company's document
                CollectionReference salesCollection = companyRef.Collection("sales");
                Console.WriteLine("Retrieved sales collection reference.");

                // Calculate the start and end dates for the current month
                DateTime today = DateTime.UtcNow;
                DateTime startDate = new DateTime(today.Year, today.Month, 1, 0, 0, 0, DateTimeKind.Utc);
                DateTime endDate = startDate.AddMonths(1);
                Console.WriteLine($"Start Date: {startDate}, End Date: {endDate}");

                Dictionary<string, double> productSalesByCashValue = new Dictionary<string, double>();

                // Query for sales records within the current month
                QuerySnapshot querySnapshot = await salesCollection
                    .WhereGreaterThanOrEqualTo("Date", startDate)
                    .WhereLessThan("Date", endDate)
                    .GetSnapshotAsync();
                Console.WriteLine($"Queried for sales records. Found {querySnapshot.Count} records.");

                foreach (var salesDocument in querySnapshot)
                {
                    // Get the "items" subcollection within each sales document
                    CollectionReference itemsCollection = salesDocument.Reference.Collection("items");

                    // Iterate through items within the "items" subcollection
                    QuerySnapshot itemsSnapshot = await itemsCollection.GetSnapshotAsync();

                    foreach (var itemDocument in itemsSnapshot)
                    {
                        if (itemDocument.Exists)
                        {
                            // Extract the "Name," "Quantity," and "Price" fields
                            var itemData = itemDocument.ToDictionary();
                            Console.WriteLine("Extracted item data: " + string.Join(", ", itemData.Select(kvp => $"{kvp.Key}: {kvp.Value}")));

                            if (itemData.ContainsKey("Name") && itemData["Name"] is string itemName
                                && itemData.ContainsKey("Quantity") && int.TryParse(itemData["Quantity"].ToString(), out int quantity)
                                && itemData.ContainsKey("Price") && double.TryParse(itemData["Price"].ToString(), out double price))
                            {
                                double cashValue = price * quantity;

                                // If the item is not in the dictionary, add it with the cash value
                                if (!productSalesByCashValue.ContainsKey(itemName))
                                {
                                    productSalesByCashValue[itemName] = cashValue;
                                }
                                else
                                {
                                    // Otherwise, update the cash value
                                    productSalesByCashValue[itemName] += cashValue;
                                }
                            }
                            else
                            {
                              
                            }
                        }
                    }
                }

                // Sort the products by cash value in descending order
                var topSellersByCashValue = productSalesByCashValue.OrderByDescending(x => x.Value).Take(3);
                Console.WriteLine("Top Sellers by Cash");

                foreach (var seller in topSellersByCashValue)
                {
                    Console.WriteLine($"{seller.Key}: ${seller.Value}");
                }

                // Create a series for the bar chart
                Series series = new Series("TopSellersByCashValue");
                series.ChartType = SeriesChartType.Column;

                // Add data points to the series for each top seller by cash value
                foreach (var seller in topSellersByCashValue)
                {
                    series.Points.AddXY(seller.Key, seller.Value);
                }

                // Update the bar chart in the view
                view.UpdateBarChartBestSellers(series);
            }
            catch (Exception ex)
            {
                // Handle the error or return a default value if necessary
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }



    }
}
