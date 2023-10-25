using System;
using System.Collections.Generic;
using Google.Cloud.Firestore;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Reports_Management
{
    public class ReportsModel
    {
        private FirestoreDb db;
        private ProductModel productModel;

        public ReportsModel(FirestoreDb firestoreDb, ProductModel productModel)
        {
            db = firestoreDb;
            this.productModel = productModel;
        }

        public async Task<double> CalculateTotalSalesThisMonth()
        {
            string userId = await productModel.GetUserIdFromFirebaseAuthenticationAsync();

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
            string userId = await productModel.GetUserIdFromFirebaseAuthenticationAsync();

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

        public async Task GetRunningLowProducts(int thresholdQuantity)
        {
            string userId = await productModel.GetUserIdFromFirebaseAuthenticationAsync();

            if (userId == null)
            {
                // Handle the unauthenticated user case as needed
                return;
            }

            DocumentReference companyRef = db.Collection("companies").Document(userId);
            CollectionReference productsCollection = companyRef.Collection("products");

            QuerySnapshot querySnapshot = await productsCollection
                .WhereLessThan("Quantity", thresholdQuantity)
                .GetSnapshotAsync();

            List<string> lowProducts = new List<string>();

            foreach (var documentSnapshot in querySnapshot)
            {
                if (documentSnapshot.Exists)
                {
                    var productData = documentSnapshot.ToDictionary();
                    if (productData.ContainsKey("Name") && productData["Name"] is string productName)
                    {
                        lowProducts.Add(productName);
                    }
                }
            }

            // Process the list of low products as needed (e.g., notify users)
        }

        public async Task<double[]> CalculateSalesByDay()
        {
            string userId = await productModel.GetUserIdFromFirebaseAuthenticationAsync();

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
            string userId = await productModel.GetUserIdFromFirebaseAuthenticationAsync();

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

        public async Task<Dictionary<string, double>> CalculateBestSellersByCashValue()
        {
            string userId = await productModel.GetUserIdFromFirebaseAuthenticationAsync();

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
    }
}
