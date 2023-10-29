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

namespace Inventory_Managment_System.Reports_Management
{
    public partial class ReportsView : UserControl
    {

        public event Action<string, double, DateTime> AddExpenseClicked;
        public event Action<string> SearchButtonClicked;
        public event Action<string,DateTime> DeleteExpenseClicked;




        public ReportsView()
        {
            
            InitializeComponent();
            addExpenseButton.Click += (sender, e) => OnAddExpenseClicked();
            searchButton.Click += (sender, e) => OnSearchButtonClicked();
            deleteExpenseButton.Click += (sender, e) => OnDeleteExpenseClicked();
            expenseListView.MouseClick += OnExpenseListViewMouseClick;


        }

        // Other view methods and properties...

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
            // Set the View property of the basketListView to Details
            expenseListView.View = View.Details;
            expenseListView.Columns.Add("Name", 50);     // Column 1: Name
            expenseListView.Columns.Add("Amount", 50); // Column 2:
            expenseListView.Columns.Add("Date", 50);



            SalesListView.View = View.Details;
            SalesListView.Columns.Add("Date", 50);     // Column 1: Name
            SalesListView.Columns.Add("Total", 50); // Column 2:
            
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
            dateOfExpenseTextBox.Text = date.ToString();


        }

        public void PopulateExpenseListView(List<Expense> expenses)
        {
            // Clear any existing items in the list view
            expenseListView.Items.Clear();

            foreach (var expense in expenses)
            {
                // Create a ListViewItem to represent each expense and add it to the list view
                var item = new ListViewItem(new[] { expense.Name, expense.Amount.ToString("0.00"), expense.Date.ToString("MM/dd/yyyy") });
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

        private void OnExpenseListViewMouseClick(object sender, MouseEventArgs e)
        {
            // Get the selected item
            ListViewItem selectedExpense = expenseListView.GetItemAt(e.X, e.Y);
          
            if (selectedExpense != null)
            {
                string expenseName = selectedExpense.SubItems[0].Text; // Assuming the name is in the first sub-item
                searchBox.Text = expenseName;
                SearchButtonClicked?.Invoke(expenseName);
            }
        }


        public void PopulateSalesListView(List<SaleRecord> salesRecords)
        {
            // Clear any existing items in the list view
            SalesListView.Items.Clear();

            foreach (var sale in salesRecords)
            {
                // Create a ListViewItem to represent each sale record and add it to the list view
                var item = new ListViewItem(new[] { sale.Date.ToString("MM/dd/yyyy"), sale.TotalSalePrice.ToString("0.00") });
                SalesListView.Items.Add(item);
            }
        }


    }

}