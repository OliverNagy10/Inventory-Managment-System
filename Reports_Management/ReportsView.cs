using Inventory_Managment_System.Sales_Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Inventory_Managment_System.Reports_Management
{
    public partial class ReportsView : UserControl
    {

        public event Action<string, double, DateTime> AddExpenseClicked;
        public event Action<string> SearchButtonClicked;
        public event Action<string,DateTime> DeleteExpenseClicked;
        public event Action DownloadReportClicked;
        public event Action ExitClicked;




        public ReportsView()
        {
            
            InitializeComponent();
            addExpenseButton.Click += (sender, e) => OnAddExpenseClicked();
            searchButton.Click += (sender, e) => OnSearchButtonClicked();
            deleteExpenseButton.Click += (sender, e) => OnDeleteExpenseClicked();
            expenseListView.MouseClick += OnExpenseListViewMouseClick;
            downloadReportButton.Click += (sender, e) => OnDownloadClicked();
            exitButton.Click += (sender, e) => OnExitClicked();


        }

     

        private void OnAddExpenseClicked()
        {
            var expenseName = GetExpenseName();
            var expenseAmount = GetExpenseAmount();
            var dateOfExpense = GetExpenseDate();
            AddExpenseClicked?.Invoke(expenseName, expenseAmount, dateOfExpense);
            searchButton.Click += (sender, e) => OnSearchButtonClicked();
        }


        private void ReportsView_Load(object sender, EventArgs e)
        {
         
            
        }

        public void DisplayTotalSalesRevenue(double totalSalesRevenue)
        {
            // Update the SalesRevenueHolder label with the calculated total sales revenue
            SalesRevenueHolder.Text = totalSalesRevenue.ToString("0.00");
        }

        public void DisplayTotalNetProfit(double totalNetProfit)
        {
            NetProfitHolder.Text = totalNetProfit.ToString("0.0");


        }

        public void DisplayTotalNetProfitMargin(double totalNetProfitMargin)
        {

            netProfitMarginHolder.Text = totalNetProfitMargin.ToString("0.0");
        }

        public void DisplayTotalGrossProfit(double totalGrossProfit)
        {
            // Update the SalesRevenueHolder label with the calculated total sales revenue
            grossProfitHolder.Text = totalGrossProfit.ToString("0.00");
        }

        public void DisplayTotalGrossMargin(double totalGrossMargin)
        {
            grossMarginHolder.Text = totalGrossMargin.ToString("0.00" + "%");

        }

        public string GetExpenseName()
        {
            return expenseNameTextBox.Text;

        }

        public void SetExpenseName(string name)
        {

            expenseNameTextBox.Text = name;
        }

        public double GetExpenseAmount()
        {
            if (double.TryParse(ExpenseAmountTextBox.Text, out double amount))
            {
                return amount;
            }
            return 0.0; // You can handle the parsing error as needed

        }

        public void SetExpenseAmount(double value)
        {

            ExpenseAmountTextBox.Text = value.ToString();
        }

        public DateTime GetExpenseDate()
        {
            if (DateTime.TryParseExact(dateOfExpenseTextBox.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                Console.WriteLine("GetExpenseDate: Parsed date successfully: " + date.ToString("MM/dd/yyyy"));
                return date;
            }
            else
            {
                Console.WriteLine("GetExpenseDate: Failed to parse date, using default value.");
                return DateTime.MinValue; // Or any other appropriate default value
            }
        }

        public void SetExpenseDate(DateTime date)
        {
            dateOfExpenseTextBox.Text = date.ToString("MM/dd/yyyy");
        }


        public void PopulateExpenseListView(List<Expense> expenses)
        {
            expenseListView.Items.Clear();

            foreach (var expense in expenses)
            {
                var item = new ListViewDataItem(expense.Name);
                item.SubItems.Add(expense.Name);
                item.SubItems.Add(expense.Amount.ToString("0.00"));
                item.SubItems.Add(expense.Date.ToString("MM/dd/yyyy"));

                expenseListView.Items.Add(item);
            }
        }


        private void OnSearchButtonClicked()
        {
            var searchName = GetSearchName();
            SearchButtonClicked?.Invoke(searchName);
        }

        public string GetSearchName()
        {
            return searchBox.Text;
        }

        public void PopulateExpenseDetails(List<Expense> expenses)
        {
            if (expenses.Count > 0)
            {
                var firstExpense = expenses[0];
                SetExpenseName(firstExpense.Name);
                SetExpenseAmount(firstExpense.Amount);
                SetExpenseDate(firstExpense.Date);
            }
            else
            {
                // Handle the case where no matching expense was found
                // You can clear the fields or show an error message in the view.
            }
        }

        private void OnDeleteExpenseClicked()
        {
            string expenseName = GetExpenseName();
            DateTime date = GetExpenseDate(); // Be sure to parse the date from the dateOfExpenseTextBox

            // Raise an event to notify the controller to delete the expense
            Console.WriteLine("OnDeleteExpenseClicked: Delete expense request - Name: " + expenseName + ", Date: " + date.ToString("MM/dd/yyyy"));
            DeleteExpenseClicked?.Invoke(expenseName, date);
        }

        private void OnDownloadClicked()
        {
         
            DownloadReportClicked?.Invoke();
        }

        private void OnExitClicked()
        {

            ExitClicked?.Invoke();
        }

        private void OnExpenseListViewMouseClick(object sender, EventArgs e)
        {
            RadListView listView = (RadListView)sender;

            if (listView.SelectedItem != null)
            {
                string expenseName = listView.SelectedItem[0].ToString(); 
                searchBox.Text = expenseName;
                SearchButtonClicked?.Invoke(expenseName);
            }
        }

        public void PopulateSalesListView(List<SaleRecord> salesRecords)
        {
            SalesListView.Items.Clear();

            foreach (var sale in salesRecords)
            {
                var item = new ListViewDataItem(sale.Date.ToString("MM/dd/yyyy"));
                item.SubItems.Add(sale.Date.ToString("MM/dd/yyyy"));
                item.SubItems.Add(sale.TotalSalePrice.ToString("0.00"));

                SalesListView.Items.Add(item);
            }
        }


        public void PopulateMonthlySalesChart(Dictionary<string, double> monthlySales)
        {
            // Clear any existing data points in the chart
            monthlySalesChart.Series[0].Points.Clear();

            // Populate the chart with monthly sales data
            foreach (var monthYear in monthlySales.Keys)
            {
                double salesAmount = monthlySales[monthYear];
                DateTime date = DateTime.ParseExact(monthYear, "yyyy-MM", CultureInfo.InvariantCulture);

                // Add a data point to the chart
                monthlySalesChart.Series[0].Points.AddXY(date, salesAmount);
            }
        }

        public void PopulateWorstSellersYearChart(Dictionary<string, int> worstSellers)
        {
            // Clear any existing data points in the chart
            worstSellersYear.Series[0].Points.Clear();

            // Populate the chart with worst sellers data
            foreach (var product in worstSellers)
            {
                worstSellersYear.Series[0].Points.AddXY(product.Key, product.Value);
            }
        }

        public void PopulateBestSellersYearChart(Dictionary<string, int> bestSellers)
        {
            // Clear any existing data points in the chart
            bestSellersYear.Series[0].Points.Clear();

            // Populate the chart with best sellers data
            foreach (var product in bestSellers)
            {
                bestSellersYear.Series[0].Points.AddXY(product.Key, product.Value);
            }
        }

        public void PopulateSalesbyWeekYearChart(double[] weeklySales)
        {
            // Clear any existing data points in the chart
            SalesbyWeekYear.Series[0].Points.Clear();

            // Populate the chart with weekly sales data
            for (int week = 0; week < weeklySales.Length; week++)
            {
                SalesbyWeekYear.Series[0].Points.AddY(weeklySales[week]);
            }
        }

        public void PopulateMostProfitableProductsChart(List<(string ProductName, double ProfitMargin)> products)
        {
            // Clear any existing data points in the chart
            mostProfiableProducts.Series[0].Points.Clear();

            // Populate the chart with most profitable products data
            foreach (var product in products)
            {
                mostProfiableProducts.Series[0].Points.AddXY(product.ProductName, product.ProfitMargin);
            }
        }

        private void SalesRevenueHolder_Click(object sender, EventArgs e)
        {

        }

        private void salesRevenueLabel_Click(object sender, EventArgs e)
        {

        }
    }

}