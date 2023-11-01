using System;
using System.Collections.Generic;
using Google.Cloud.Firestore;
using System.Linq;
using System.Threading.Tasks;
using Inventory_Managment_System.Sales_Manager;
using Telerik.WinControls.UI;

namespace Inventory_Managment_System.Reports_Management
{
    public class ReportsModel
    {
        private FirestoreDb db;
        private ProductModel productModel;
        private string userId;

        public ReportsModel(FirestoreDb firestoreDb, ProductModel productModel)
        {
            db = firestoreDb;
            this.productModel = productModel;
            this.userId = productModel.GetUserIdFromFirebaseAuthentication();
        }



        public async Task<double> CalculateNetProfitMargin()
        {
            try
            {
                // Calculate the net profit using the existing method
                double netProfit = await CalculateNetProfit();

                // Calculate the total sales for the year using the existing method
                double totalSales = await CalculateTotalSalesThisYear();

                // Calculate the net profit margin

                double netProfitMargin = (netProfit / totalSales) ;


                return netProfitMargin;
            }
            catch (Exception ex)
            {
                // Handle the error or return an error indicator as needed
                Console.WriteLine("An error occurred: " + ex.Message);
                return 0.0; // Return 0 or handle the error appropriately
            }
        }

        public async Task<List<SaleRecord>> LoadSales()
        {
            

            if (userId == null)
            {
                // Handle the unauthenticated user case as needed
                return new List<SaleRecord>(); // Return an empty list or handle the error appropriately
            }

            try
            {
                // Get a reference to the company's document in the "companies" collection
                DocumentReference companyRef = db.Collection("companies").Document(userId);

                // Get a reference to the "sales" collection within the company's document
                CollectionReference salesCollection = companyRef.Collection("sales");

                // Query the sales collection
                QuerySnapshot querySnapshot = await salesCollection.GetSnapshotAsync();

                var sales = new List<SaleRecord>();

                foreach (var documentSnapshot in querySnapshot)
                {
                    if (documentSnapshot.Exists)
                    {
                        var saleData = documentSnapshot.ToDictionary();
                        if (saleData.ContainsKey("Date") && saleData["Date"] is Timestamp date &&
                            saleData.ContainsKey("TotalSalePrice") && saleData["TotalSalePrice"] is double salePrice)
                        {
                            sales.Add(new SaleRecord
                            {
                                Date = date.ToDateTime(),
                                TotalSalePrice = salePrice
                            });
                        }
                    }
                }

                return sales;
            }
            catch (Exception ex)
            {
                // Handle the error or return an error indicator as needed
                Console.WriteLine("An error occurred: " + ex.Message);
                return new List<SaleRecord>(); // Return an empty list or handle the error appropriately
            }
        }

        public async Task<List<Expense>> LoadExpenses()
        {
            

            if (userId == null)
            {
                // Handle the unauthenticated user case as needed
                return new List<Expense>(); // Return an empty list or handle the error appropriately
            }

            try
            {
                // Get a reference to the user's document in the "companies" collection
                DocumentReference userRef = db.Collection("companies").Document(userId);

                // Get a reference to the "expenses" collection within the user's document
                CollectionReference expensesCollection = userRef.Collection("expenses");

                // Query the entire expenses collection
                QuerySnapshot querySnapshot = await expensesCollection.GetSnapshotAsync();

                var expenses = new List<Expense>();

                foreach (var documentSnapshot in querySnapshot)
                {
                    if (documentSnapshot.Exists)
                    {
                        var expenseData = documentSnapshot.ToDictionary();

                        if (expenseData.ContainsKey("Name") && expenseData["Name"] is string name &&
                            expenseData.ContainsKey("Date") && expenseData["Date"] is Timestamp date &&
                            expenseData.ContainsKey("Amount") && expenseData["Amount"] is double amount)
                        {
                            expenses.Add(new Expense
                            {
                                Name = name,
                                Date = date.ToDateTime(),
                                Amount = amount
                            });
                        }
                    }
                }

                return expenses;
            }
            catch (Exception ex)
            {
                // Handle the error or return an error indicator as needed
                Console.WriteLine("An error occurred: " + ex.Message);
                return new List<Expense>(); // Return an empty list or handle the error appropriately
            }
        }

        public async Task<List<Expense>> SearchExpense(string name)
        {
           

            if (userId == null)
            {
                // Handle the unauthenticated user case as needed
                return new List<Expense>(); // Return an empty list or handle the error appropriately
            }

            try
            {
                // Get a reference to the user's document in the "companies" collection
                DocumentReference userRef = db.Collection("companies").Document(userId);

                // Get a reference to the "expenses" collection within the user's document
                CollectionReference expensesCollection = userRef.Collection("expenses");

                // Query the expenses collection to find expense documents with matching name
                QuerySnapshot querySnapshot = await expensesCollection.WhereEqualTo("Name", name).GetSnapshotAsync();

                var expenses = new List<Expense>();

                foreach (var documentSnapshot in querySnapshot)
                {
                    if (documentSnapshot.Exists)
                    {
                        var expenseData = documentSnapshot.ToDictionary();

                        if (expenseData.ContainsKey("Date") && expenseData["Date"] is Timestamp date &&
                            expenseData.ContainsKey("Amount") && expenseData["Amount"] is double amount)
                        {
                            expenses.Add(new Expense
                            {
                                Name = name,
                                Date = date.ToDateTime(),
                                Amount = amount
                            });
                        }
                    }
                }

                return expenses;
            }
            catch (Exception ex)
            {
                // Handle the error or return an error indicator as needed
                Console.WriteLine("An error occurred: " + ex.Message);
                return new List<Expense>(); // Return an empty list or handle the error appropriately
            }
        }

        public async Task<string> DeleteExpenseAsync(string expenseName, DateTime date)
        {
            

            if (userId == null)
            {
                return "User is not authenticated.";
            }

            try
            {
                // Get a reference to the user's document in the "companies" collection
                DocumentReference userRef = db.Collection("companies").Document(userId);

                // Get a reference to the "expenses" collection within the user's document
                CollectionReference expensesCollection = userRef.Collection("expenses");

                // Query the expenses collection to find expense documents with matching name and date
                QuerySnapshot querySnapshot = await expensesCollection
                    .WhereEqualTo("Name", expenseName)
                    .WhereEqualTo("Date", date)
                    .GetSnapshotAsync();

                // Iterate through the matching expense documents and delete them
                foreach (var documentSnapshot in querySnapshot)
                {
                    if (documentSnapshot.Exists)
                    {
                        await documentSnapshot.Reference.DeleteAsync();
                    }
                }

                return "Expenses deleted successfully.";
            }
            catch (Exception ex)
            {
                return "An error occurred: " + ex.Message;
            }
        }

        public async Task<string> AddExpenseAsync(string expenseName, double amount, DateTime date)
        {
            if (userId == null)
            {
                Console.WriteLine("AddExpenseAsync: User is not authenticated.");
                return "User is not authenticated.";
            }

            try
            {
                Console.WriteLine("AddExpenseAsync: Calling Firestore to add an expense...");

                // Get a reference to the user's document in the "companies" collection
                DocumentReference userRef = db.Collection("companies").Document(userId);

                // Get a reference to the "expenses" collection within the user's document
                CollectionReference expensesCollection = userRef.Collection("expenses");

                // Create a new expense document with an automatically generated document ID
                DocumentReference newExpenseRef = expensesCollection.Document();

                var newExpense = new
                {
                    Name = expenseName,
                    Amount = amount,
                    Date = date
                };

                Console.WriteLine("AddExpenseAsync: Adding expense to Firestore...");

                // Add the new expense document to the "expenses" collection
                await newExpenseRef.SetAsync(newExpense);

                Console.WriteLine("AddExpenseAsync: Expense added successfully.");

                return "Expense added successfully.";
            }
            catch (Exception ex)
            {
                Console.WriteLine("AddExpenseAsync: An error occurred: " + ex.Message);
                return "An error occurred: " + ex.Message;
            }
        }


        public async Task<double> CalculateTotalGrossProfitMarginYear()
        {
            if (userId == null)
            {
                // Handle the unauthenticated user case as needed
                return 0.0; // Return 0 or handle the error appropriately
            }

            DocumentReference companyRef = db.Collection("companies").Document(userId);
            CollectionReference salesCollection = companyRef.Collection("sales");

            DateTime today = DateTime.UtcNow;
            DateTime startDate = new DateTime(today.Year, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime endDate = startDate.AddYears(1);

            QuerySnapshot querySnapshot = await salesCollection
                .WhereGreaterThanOrEqualTo("Date", startDate)
                .WhereLessThan("Date", endDate)
                .GetSnapshotAsync();

            double totalSales = 0.0;
            double totalCost = 0.0;

            foreach (var documentSnapshot in querySnapshot)
            {
                if (documentSnapshot.Exists)
                {
                    var saleData = documentSnapshot.ToDictionary();
                    if (saleData.ContainsKey("TotalSalePrice") && saleData["TotalSalePrice"] is double salePrice)
                    {
                        double cost = 0.0;

                        CollectionReference itemsCollection = documentSnapshot.Reference.Collection("items");
                        QuerySnapshot itemsSnapshot = await itemsCollection.GetSnapshotAsync();

                        foreach (var itemDocument in itemsSnapshot)
                        {
                            if (itemDocument.Exists)
                            {
                                var itemData = itemDocument.ToDictionary();
                                if (itemData.ContainsKey("Cost") && itemData["Cost"] is double itemCost)
                                {
                                    cost += itemCost;
                                }
                            }
                        }

                        totalSales += salePrice;
                        totalCost += cost;
                    }
                }
            }

            // Calculate Gross Profit Margin as a decimal (not percentage)
            if (totalSales > 0)
            {
                double grossProfitMargin = (totalSales - totalCost) / totalSales;
                return grossProfitMargin;
            }
            else
            {
                return 0.0; // Handle the case where total sales are zero to avoid division by zero
            }
        }

        public async Task<double> CalculateTotalGrossProfitYear()
        {
         

            if (userId == null)
            {
                // Handle the unauthenticated user case as needed
                return 0.0; // Return 0 or handle the error appropriately
            }

            DocumentReference companyRef = db.Collection("companies").Document(userId);
            CollectionReference salesCollection = companyRef.Collection("sales");

            DateTime today = DateTime.UtcNow;
            DateTime startDate = new DateTime(today.Year, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime endDate = startDate.AddYears(1);

            QuerySnapshot querySnapshot = await salesCollection
                .WhereGreaterThanOrEqualTo("Date", startDate)
                .WhereLessThan("Date", endDate)
                .GetSnapshotAsync();

            double totalGrossMargin = 0.0;

            foreach (var documentSnapshot in querySnapshot)
            {
                if (documentSnapshot.Exists)
                {
                    var saleData = documentSnapshot.ToDictionary();
                    if (saleData.ContainsKey("TotalSalePrice") && saleData["TotalSalePrice"] is double salePrice)
                    {
                        double cost = 0.0;

                        CollectionReference itemsCollection = documentSnapshot.Reference.Collection("items");
                        QuerySnapshot itemsSnapshot = await itemsCollection.GetSnapshotAsync();

                        foreach (var itemDocument in itemsSnapshot)
                        {
                            if (itemDocument.Exists)
                            {
                                var itemData = itemDocument.ToDictionary();
                                if (itemData.ContainsKey("Cost") && itemData["Cost"] is double itemCost)
                                {
                                    cost += itemCost;
                                }
                            }
                        }

                        double grossMargin = salePrice - cost;
                        totalGrossMargin += grossMargin;
                    }
                }
            }

            return totalGrossMargin;
        }

        public async Task<double> CalculateNetProfit()
        {
           
            try
            {
                // Calculate the total gross profit for the year
                double totalGrossProfit = await CalculateTotalGrossProfitYear();

                // Get a reference to the user's document in the "companies" collection
                DocumentReference userRef = db.Collection("companies").Document(userId);

                // Get a reference to the "expenses" collection within the user's document
                CollectionReference expensesCollection = userRef.Collection("expenses");

                // Query the entire expenses collection
                QuerySnapshot querySnapshot = await expensesCollection.GetSnapshotAsync();

                double totalExpenses = 0.0;

                foreach (var documentSnapshot in querySnapshot)
                {
                    if (documentSnapshot.Exists)
                    {
                        var expenseData = documentSnapshot.ToDictionary();

                        if (expenseData.ContainsKey("Amount") && expenseData["Amount"] is double expenseAmount)
                        {
                            totalExpenses += expenseAmount;
                        }
                    }
                }

                // Calculate the net profit
                double netProfit = totalGrossProfit - totalExpenses;
                return netProfit;
            }
            catch (Exception ex)
            {
                // Handle the error or return an error indicator as needed
                Console.WriteLine("An error occurred: " + ex.Message);
                return 0.0; // Return 0 or handle the error appropriately
            }
        }

        public async Task<double> CalculateTotalSalesThisYear()
        {
          
            try
            {
                DateTime today = DateTime.UtcNow;
                DateTime startDate = new DateTime(today.Year, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                DateTime endDate = startDate.AddYears(1);

                DocumentReference companyRef = db.Collection("companies").Document(userId);
                CollectionReference salesCollection = companyRef.Collection("sales");

                QuerySnapshot querySnapshot = await salesCollection
                    .WhereGreaterThanOrEqualTo("Date", startDate)
                    .WhereLessThan("Date", endDate)
                    .GetSnapshotAsync();

                double totalSales = 0.0;

                foreach (var documentSnapshot in querySnapshot)
                {
                    if (documentSnapshot.Exists)
                    {
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

        public async Task<double> CalculateTotalSalesThisMonth()
        {
           

            try
            {
                DateTime today = DateTime.UtcNow;
                DateTime startDate = new DateTime(today.Year, today.Month, 1, 0, 0, 0, DateTimeKind.Utc);
                DateTime endDate = startDate.AddMonths(1);

                DocumentReference companyRef = db.Collection("companies").Document(userId);
                CollectionReference salesCollection = companyRef.Collection("sales");

                QuerySnapshot querySnapshot = await salesCollection
                    .WhereGreaterThanOrEqualTo("Date", startDate)
                    .WhereLessThan("Date", endDate)
                    .GetSnapshotAsync();

                double totalSales = 0.0;

                foreach (var documentSnapshot in querySnapshot)
                {
                    if (documentSnapshot.Exists)
                    {
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
           

            try
            {
                if (userId == null)
                {
                    // Handle the unauthenticated user case as needed
                    return 0.0;
                }

                DocumentReference companyRef = db.Collection("companies").Document(userId);
                CollectionReference productsCollection = companyRef.Collection("products");

                QuerySnapshot querySnapshot = await productsCollection.GetSnapshotAsync();

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
                                if (int.TryParse(productData["Quantity"].ToString(), out int quantity))
                                {
                                    double productValue = price * quantity;
                                    totalValue += productValue;
                                }
                            }
                        }
                    }
                }

                return totalValue;
            }
            catch (Exception ex)
            {
                // Handle the error or return a default value if necessary
                return 0.0;
            }
        }

        public async Task<List<ListViewDataItem>> GetRunningLowProducts(int thresholdQuantity)
        {
            List<ListViewDataItem> lowProducts = new List<ListViewDataItem>();

            if (userId == null)
            {
                // Handle the unauthenticated user case as needed
                return lowProducts;
            }

            DocumentReference companyRef = db.Collection("companies").Document(userId);
            CollectionReference productsCollection = companyRef.Collection("products");

            QuerySnapshot querySnapshot = await productsCollection
                .WhereLessThan("Quantity", thresholdQuantity)
                .GetSnapshotAsync();

            foreach (var documentSnapshot in querySnapshot)
            {
                if (documentSnapshot.Exists)
                {
                    var productData = documentSnapshot.ToDictionary();
                    if (productData.ContainsKey("Name") && productData["Name"] is string productName)
                    {
                        var dataItem = new ListViewDataItem();
                        dataItem[0] = productName;  // Set the name
                       

                        lowProducts.Add(dataItem);
                    }
                }
            }

            return lowProducts;
        }

        public async Task<double[]> CalculateSalesByDay()
        {
           

            if (userId == null)
            {
                // Handle the unauthenticated user case as needed
                return null;
            }

            DocumentReference companyRef = db.Collection("companies").Document(userId);
            CollectionReference salesCollection = companyRef.Collection("sales");

            DateTime today = DateTime.UtcNow;
            DateTime startDate = today.Date.AddDays(-(int)today.DayOfWeek);
            DateTime endDate = startDate.AddDays(7);

            double[] dailySales = new double[7];

            QuerySnapshot querySnapshot = await salesCollection
                .WhereGreaterThanOrEqualTo("Date", startDate)
                .WhereLessThan("Date", endDate)
                .GetSnapshotAsync();

            foreach (var documentSnapshot in querySnapshot)
            {
                if (documentSnapshot.Exists)
                {
                    var saleData = documentSnapshot.ToDictionary();
                    if (saleData.ContainsKey("Date") && saleData["Date"] is Timestamp saleDate
                        && saleData.ContainsKey("TotalSalePrice") && saleData["TotalSalePrice"] is double salePrice)
                    {
                        int dayOfWeek = (int)saleDate.ToDateTime().DayOfWeek;
                        dailySales[dayOfWeek] += salePrice;
                    }
                }
            }

            // Process the daily sales data as needed

            return dailySales;
        }

        public async Task<Dictionary<string, int>> CalculateBestSellers()
        {
           

            if (userId == null)
            {
                // Handle the unauthenticated user case as needed
                return null;
            }

            DocumentReference companyRef = db.Collection("companies").Document(userId);
            CollectionReference salesCollection = companyRef.Collection("sales");

            DateTime today = DateTime.UtcNow;
            DateTime startDate = new DateTime(today.Year, today.Month, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime endDate = startDate.AddMonths(1);

            Dictionary<string, int> productSales = new Dictionary<string, int>();

            QuerySnapshot querySnapshot = await salesCollection
                .WhereGreaterThanOrEqualTo("Date", startDate)
                .WhereLessThan("Date", endDate)
                .GetSnapshotAsync();

            foreach (var salesDocument in querySnapshot)
            {
                CollectionReference itemsCollection = salesDocument.Reference.Collection("items");

                QuerySnapshot itemsSnapshot = await itemsCollection.GetSnapshotAsync();

                foreach (var itemDocument in itemsSnapshot)
                {
                    if (itemDocument.Exists)
                    {
                        var itemData = itemDocument.ToDictionary();

                        if (itemData.ContainsKey("Name") && itemData["Name"] is string itemName
                            && itemData.ContainsKey("Quantity") && int.TryParse(itemData["Quantity"].ToString(), out int quantity))
                        {
                            if (!productSales.ContainsKey(itemName))
                            {
                                productSales[itemName] = quantity;
                            }
                            else
                            {
                                productSales[itemName] += quantity;
                            }
                        }
                    }
                }
            }

            var topSellers = productSales.OrderByDescending(x => x.Value).Take(3);

            // Process the list of top sellers as needed

            return topSellers.ToDictionary(x => x.Key, x => x.Value);
        }

        public async Task<Dictionary<string, int>> CalculateWorstSellersbyYear()
        {
         

            if (userId == null)
            {
                // Handle the unauthenticated user case as needed
                return null;
            }

            DocumentReference companyRef = db.Collection("companies").Document(userId);
            CollectionReference salesCollection = companyRef.Collection("sales");

            DateTime today = DateTime.UtcNow;
            DateTime startDate = new DateTime(today.Year, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime endDate = startDate.AddYears(1);

            Dictionary<string, int> productSales = new Dictionary<string, int>();

            QuerySnapshot querySnapshot = await salesCollection
                .WhereGreaterThanOrEqualTo("Date", startDate)
                .WhereLessThan("Date", endDate)
                .GetSnapshotAsync();

            foreach (var salesDocument in querySnapshot)
            {
                CollectionReference itemsCollection = salesDocument.Reference.Collection("items");

                QuerySnapshot itemsSnapshot = await itemsCollection.GetSnapshotAsync();

                foreach (var itemDocument in itemsSnapshot)
                {
                    if (itemDocument.Exists)
                    {
                        var itemData = itemDocument.ToDictionary();

                        if (itemData.ContainsKey("Name") && itemData["Name"] is string itemName
                            && itemData.ContainsKey("Quantity") && int.TryParse(itemData["Quantity"].ToString(), out int quantity))
                        {
                            if (!productSales.ContainsKey(itemName))
                            {
                                productSales[itemName] = quantity;
                            }
                            else
                            {
                                productSales[itemName] += quantity;
                            }
                        }
                    }
                }
            }

            var worstSellers = productSales.OrderBy(x => x.Value).Take(3);

            // Process the list of worst sellers as needed

            return worstSellers.ToDictionary(x => x.Key, x => x.Value);
        }

        public async Task<Dictionary<string, int>> CalculateBestSellersYear()
        {
           

            if (userId == null)
            {
                // Handle the unauthenticated user case as needed
                return null;
            }

            DocumentReference companyRef = db.Collection("companies").Document(userId);
            CollectionReference salesCollection = companyRef.Collection("sales");

            DateTime today = DateTime.UtcNow;
            DateTime startDate = new DateTime(today.Year, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime endDate = startDate.AddYears(1);

            Dictionary<string, int> productSales = new Dictionary<string, int>();

            QuerySnapshot querySnapshot = await salesCollection
                .WhereGreaterThanOrEqualTo("Date", startDate)
                .WhereLessThan("Date", endDate)
                .GetSnapshotAsync();

            foreach (var salesDocument in querySnapshot)
            {
                CollectionReference itemsCollection = salesDocument.Reference.Collection("items");

                QuerySnapshot itemsSnapshot = await itemsCollection.GetSnapshotAsync();

                foreach (var itemDocument in itemsSnapshot)
                {
                    if (itemDocument.Exists)
                    {
                        var itemData = itemDocument.ToDictionary();

                        if (itemData.ContainsKey("Name") && itemData["Name"] is string itemName
                            && itemData.ContainsKey("Quantity") && int.TryParse(itemData["Quantity"].ToString(), out int quantity))
                        {
                            if (!productSales.ContainsKey(itemName))
                            {
                                productSales[itemName] = quantity;
                            }
                            else
                            {
                                productSales[itemName] += quantity;
                            }
                        }
                    }
                }
            }

            var bestSellers = productSales.OrderByDescending(x => x.Value).Take(3);

            // Process the list of best sellers as needed

            return bestSellers.ToDictionary(x => x.Key, x => x.Value);
        }

        public async Task<double[]> SalesForEachWeekYear()
        {
            

            if (userId == null)
            {
                // Handle the unauthenticated user case as needed
                return null;
            }

            DocumentReference companyRef = db.Collection("companies").Document(userId);
            CollectionReference salesCollection = companyRef.Collection("sales");

            DateTime today = DateTime.UtcNow;
            DateTime startDate = new DateTime(today.Year, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime endDate = startDate.AddDays(7);

            double[] weeklySales = new double[52]; // 52 weeks in a year

            for (int week = 0; week < 52; week++)
            {
                QuerySnapshot querySnapshot = await salesCollection
                    .WhereGreaterThanOrEqualTo("Date", startDate)
                    .WhereLessThan("Date", endDate)
                    .GetSnapshotAsync();

                foreach (var documentSnapshot in querySnapshot)
                {
                    if (documentSnapshot.Exists)
                    {
                        var saleData = documentSnapshot.ToDictionary();
                        if (saleData.ContainsKey("TotalSalePrice") && saleData["TotalSalePrice"] is double salePrice)
                        {
                            weeklySales[week] += salePrice;
                        }
                    }
                }

                // Move to the next week
                startDate = endDate;
                endDate = startDate.AddDays(7);
            }

            return weeklySales;
        }

        public async Task<List<(string ProductName, double ProfitMargin)>> MostProfitableProducts(int n)
        {
            

            if (userId == null)
            {
                // Handle the unauthenticated user case as needed
                return null;
            }

            // Calculate the total gross profit margin for the year
            double totalGrossMargin = await CalculateTotalGrossProfitYear();

            // Get the best selling products
            Dictionary<string, int> bestSellers = await CalculateBestSellers();

            DocumentReference companyRef = db.Collection("companies").Document(userId);
            CollectionReference productsCollection = companyRef.Collection("products");

            QuerySnapshot productSnapshot = await productsCollection.GetSnapshotAsync();

            var mostProfitableProducts = new List<(string ProductName, double ProfitMargin)>();

            foreach (var productDocument in productSnapshot)
            {
                if (productDocument.Exists)
                {
                    var productData = productDocument.ToDictionary();
                    if (productData.ContainsKey("Name") && productData["Name"] is string productName
                        && productData.ContainsKey("Price") && productData["Price"] is double price
                        && productData.ContainsKey("Cost") && productData["Cost"] is double cost)
                    {
                        double productGrossMargin = price - cost;
                        if (bestSellers.ContainsKey(productName))
                        {
                            // Adjust the product's gross margin based on its sales quantity
                            productGrossMargin *= bestSellers[productName];
                        }
                        mostProfitableProducts.Add((productName, productGrossMargin));
                    }
                }
            }

            // Sort products by profit margin and take the top 'n' most profitable
            mostProfitableProducts = mostProfitableProducts.OrderByDescending(x => x.ProfitMargin).Take(n).ToList();

            return mostProfitableProducts;
        }

        public async Task<Dictionary<string, double>> CalculateBestSellersByCashValue()
        {

            if (userId == null)
            {
                // Handle the unauthenticated user case as needed
                return null;
            }

            DocumentReference companyRef = db.Collection("companies").Document(userId);
            CollectionReference salesCollection = companyRef.Collection("sales");

            DateTime today = DateTime.UtcNow;
            DateTime startDate = new DateTime(today.Year, today.Month, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime endDate = startDate.AddMonths(1);

            Dictionary<string, double> productSalesByCashValue = new Dictionary<string, double>();

            QuerySnapshot querySnapshot = await salesCollection
                .WhereGreaterThanOrEqualTo("Date", startDate)
                .WhereLessThan("Date", endDate)
                .GetSnapshotAsync();

            foreach (var salesDocument in querySnapshot)
            {
                CollectionReference itemsCollection = salesDocument.Reference.Collection("items");

                QuerySnapshot itemsSnapshot = await itemsCollection.GetSnapshotAsync();

                foreach (var itemDocument in itemsSnapshot)
                {
                    if (itemDocument.Exists)
                    {
                        var itemData = itemDocument.ToDictionary();

                        if (itemData.ContainsKey("Name") && itemData["Name"] is string itemName
                            && itemData.ContainsKey("Quantity") && int.TryParse(itemData["Quantity"].ToString(), out int quantity)
                            && itemData.ContainsKey("Price") && double.TryParse(itemData["Price"].ToString(), out double price))
                        {
                            double cashValue = price * quantity;

                            if (!productSalesByCashValue.ContainsKey(itemName))
                            {
                                productSalesByCashValue[itemName] = cashValue;
                            }
                            else
                            {
                                productSalesByCashValue[itemName] += cashValue;
                            }
                        }
                    }
                }
            }

            var topSellersByCashValue = productSalesByCashValue.OrderByDescending(x => x.Value).Take(3);

            // Process the list of top sellers by cash value as needed

            return topSellersByCashValue.ToDictionary(x => x.Key, x => x.Value);
        }

        public async Task<Dictionary<string, double>> CalculateTotalSalesForEachMonth()
        {
            

            if (userId == null)
            {
                // Handle the unauthenticated user case as needed
                return new Dictionary<string, double>(); // Return an empty dictionary or handle the error appropriately
            }

            try
            {
                // Get a reference to the company's document in the "companies" collection
                DocumentReference companyRef = db.Collection("companies").Document(userId);

                // Get a reference to the "sales" collection within the company's document
                CollectionReference salesCollection = companyRef.Collection("sales");

                // Query the sales collection
                QuerySnapshot querySnapshot = await salesCollection.GetSnapshotAsync();

                var monthlySales = new Dictionary<string, double>();

                foreach (var documentSnapshot in querySnapshot)
                {
                    if (documentSnapshot.Exists)
                    {
                        var saleData = documentSnapshot.ToDictionary();
                        if (saleData.ContainsKey("Date") && saleData["Date"] is Timestamp date &&
                            saleData.ContainsKey("TotalSalePrice") && saleData["TotalSalePrice"] is double salePrice)
                        {
                            var monthYear = date.ToDateTime().ToString("yyyy-MM"); // Format: YYYY-MM
                            if (monthlySales.ContainsKey(monthYear))
                            {
                                monthlySales[monthYear] += salePrice;
                            }
                            else
                            {
                                monthlySales[monthYear] = salePrice;
                            }
                        }
                    }
                }

                return monthlySales;
            }
            catch (Exception ex)
            {
                // Handle the error or return an error indicator as needed
                Console.WriteLine("An error occurred: " + ex.Message);
                return new Dictionary<string, double>(); // Return an empty dictionary or handle the error appropriately
            }
        }

    }
}
