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
            view.AddExpenseClicked += async (expenseName, expenseAmount, dateOfExpense) =>
            {
                var result = await AddExpense(expenseName, expenseAmount, dateOfExpense);
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

            // Update the view with the calculated values
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

    }



}

