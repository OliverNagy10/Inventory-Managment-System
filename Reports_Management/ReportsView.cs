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
     



        public ReportsView()
        {
            
            InitializeComponent();
            addExpenseButton.Click += (sender, e) => OnAddExpenseClicked();

        }

        // Other view methods and properties...

        private void OnAddExpenseClicked()
        {
            var expenseName = GetExpenseName();
            var expenseAmount = GetExpenseAmount();
            var dateOfExpense = GetExpenseDate();
            AddExpenseClicked?.Invoke(expenseName, expenseAmount, dateOfExpense);
        }


        private void ReportsView_Load(object sender, EventArgs e)
        {
            // You can initialize or load other components as needed
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

        public void SetExpenseAmount(int value)
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
        
       

    }

}