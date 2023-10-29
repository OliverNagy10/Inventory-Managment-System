using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Reports_Management
{
    public class ReportsController
    {
        private ReportsModel model;
        private ReportsView view;

        public ReportsController(ReportsView view, ReportsModel model)
        {
            this.view = view;
            this.model = model;
            view.SearchButtonClicked += async (searchName) =>
            {
                await SearchExpenseAndDisplayDetails(searchName);
            };

            view.AddExpenseClicked += async (expenseName, expenseAmount, dateOfExpense) =>
            {
                var result = await AddExpense(expenseName, expenseAmount, dateOfExpense);
                LoadExpensesAndPopulateListView();
                Initialize();
                // Handle the result as needed, e.g., show a success message or error message in the view
            };

            view.DeleteExpenseClicked += async (expenseName, date) =>
            {
                var result = await DeleteExpense(expenseName, date);
                LoadExpensesAndPopulateListView();
                Initialize();
                // Handle the result as needed, e.g., show a success message or error message in the view
            };

            Initialize();
        }

        private async void Initialize()
        {

           

            // Calculate and display the total sales revenue, gross profit, etc.
            double totalSalesRevenue = await model.CalculateTotalSalesThisYear();
            double totalGrossProfit = await model.CalculateTotalGrossProfitYear();
            double totalGrossMargin = await model.CalculateTotalGrossProfitMarginYear();
            double totalNetProfit = await model.CalculateNetProfit();
            double totalNetProfitMargin = await model.CalculateNetProfitMargin();

            LoadExpensesAndPopulateListView();
            await LoadAndPopulateSalesListView();
         
            view.DisplayTotalNetProfitMargin(totalNetProfitMargin);
            view.DisplayTotalNetProfit(totalNetProfit);
            view.DisplayTotalSalesRevenue(totalSalesRevenue);
            view.DisplayTotalGrossProfit(totalGrossProfit);
            view.DisplayTotalGrossMargin(totalGrossMargin);
        }

        private async Task<string> AddExpense(string expenseName, double amount, DateTime date)
        {
            try
            {
                // Specify the kind of the DateTime as Utc
                date = DateTime.SpecifyKind(date, DateTimeKind.Utc);

                Console.WriteLine("AddExpense: Calling model.AddExpenseAsync with name: " + expenseName + ", amount: " + amount + ", date: " + date.ToString("MM/dd/yyyy"));
                string result = await model.AddExpenseAsync(expenseName, amount, date);

                if (result == "Expense added successfully")
                {
                    Console.WriteLine("AddExpense: Expense added successfully.");
                    return "Expense added successfully.";
                }
                else
                {
                    Console.WriteLine("AddExpense: An error occurred: " + result);
                    return "An error occurred: " + result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("AddExpense: An error occurred: " + ex.Message);
                return "An error occurred: " + ex.Message;
            }
        }

        private async void LoadExpensesAndPopulateListView()
        {
            // Load expenses from the model
            var expenses = await model.LoadExpenses();

            // Populate the list view in the view with loaded expenses
            view.PopulateExpenseListView(expenses);
        }


        private async  Task SearchExpenseAndDisplayDetails(string name)
        {
            // Search for the expense and get details
            var expenses = await model.SearchExpense(name);

            // Update the view with the search results
            view.PopulateExpenseDetails(expenses);
        }

        private async Task<string> DeleteExpense(string expenseName, DateTime date)
        {
            try
            {
                // Specify the kind of the DateTime as Utc
                date = DateTime.SpecifyKind(date, DateTimeKind.Utc);

                // Call the model's DeleteExpenseAsync method to delete the expense
                Console.WriteLine("DeleteExpense: Calling model.DeleteExpenseAsync with name: " + expenseName + ", date: " + date.ToString("MM/dd/yyyy"));
                string result = await model.DeleteExpenseAsync(expenseName, date);

                if (result == "Expenses deleted successfully")
                {
                    // Handle the case where expenses were deleted successfully
                    Console.WriteLine("DeleteExpense: Expenses deleted successfully.");
                    return "Expenses deleted successfully.";
                }
                else
                {
                    // Handle the case where an error occurred
                    Console.WriteLine("DeleteExpense: An error occurred: " + result);
                    return "An error occurred: " + result;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur
                Console.WriteLine("DeleteExpense: An error occurred: " + ex.Message);
                return "An error occurred: " + ex.Message;
            }
        }


        private async Task LoadAndPopulateSalesListView()
        {
            // Load sales records from the model
            var salesRecords = await model.LoadSales();

            // Populate the SalesListView in the view with loaded sales records
            view.PopulateSalesListView(salesRecords);
        }





    }



}

