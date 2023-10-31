using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace Inventory_Managment_System.Reports_Management
{
    public class ReportsController
    {
        private ReportsModel model;
        private ReportsView view;
        private ApplicationManager mainform;
        private string IDToken;
            

        public ReportsController(ReportsView view, ReportsModel model, ApplicationManager mainform,string IDToken)
        {
            this.view = view;
            this.model = model;
            this.mainform = mainform;
            this.IDToken = IDToken;
            view.SearchButtonClicked += async (searchName) =>
            {
                await SearchExpenseAndDisplayDetails(searchName);
            };

            view.AddExpenseClicked += async (expenseName, expenseAmount, dateOfExpense) =>
            {
                var result = await AddExpense(expenseName, expenseAmount, dateOfExpense);
                LoadExpensesAndPopulateListView();
                Update();
                // Handle the result as needed, e.g., show a success message or error message in the view
            };

            view.DeleteExpenseClicked += async (expenseName, date) =>
            {
                var result = await DeleteExpense(expenseName, date);
                LoadExpensesAndPopulateListView();
                Update();

            };

            view.DownloadReportClicked += async () =>
            {
                DownloadReport();
               
            };

            view.ExitClicked += async () =>
            {
                Exit();
            };


            Initialize();
        }

        private void Exit()
        {
            mainform.InitiateDashboardView(IDToken);

        }

        private async void Initialize()
        {
            try
            {
                // Show the loading message
                view.ShowLoadingMessage(true);


                // Calculate and display the total sales revenue, gross profit, etc.
                double totalSalesRevenue = await model.CalculateTotalSalesThisYear();
            double totalGrossProfit = await model.CalculateTotalGrossProfitYear();
            double totalGrossMargin = await model.CalculateTotalGrossProfitMarginYear();
            double totalNetProfit = await model.CalculateNetProfit();
            double totalNetProfitMargin = await model.CalculateNetProfitMargin();

            LoadExpensesAndPopulateListView();
            await LoadAndPopulateSalesListView();
            await LoadAndPopulateMonthlySalesChart();
            await LoadAndPopulateWorstSellersYearChart();
            await LoadAndPopulateBestSellersYearChart();
            await LoadAndPopulateSalesbyWeekYearChart();
            await LoadAndPopulateMostProfitableProductsChart();

            view.DisplayTotalNetProfitMargin(totalNetProfitMargin);
            view.DisplayTotalNetProfit(totalNetProfit);
            view.DisplayTotalSalesRevenue(totalSalesRevenue);
            view.DisplayTotalGrossProfit(totalGrossProfit);
            view.DisplayTotalGrossMargin(totalGrossMargin);


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


        private async void Update()
        {
          

                // Calculate and display the total sales revenue, gross profit, etc.
                double totalSalesRevenue = await model.CalculateTotalSalesThisYear();
                double totalGrossProfit = await model.CalculateTotalGrossProfitYear();
                double totalGrossMargin = await model.CalculateTotalGrossProfitMarginYear();
                double totalNetProfit = await model.CalculateNetProfit();
                double totalNetProfitMargin = await model.CalculateNetProfitMargin();

                LoadExpensesAndPopulateListView();
                await LoadAndPopulateSalesListView();
                await LoadAndPopulateMonthlySalesChart();
                await LoadAndPopulateWorstSellersYearChart();
                await LoadAndPopulateBestSellersYearChart();
                await LoadAndPopulateSalesbyWeekYearChart();
                await LoadAndPopulateMostProfitableProductsChart();

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

        private async Task LoadAndPopulateMonthlySalesChart()
        {
            // Calculate total sales for each month
            var monthlySales = await model.CalculateTotalSalesForEachMonth();

            // Populate the monthly sales chart in the view
            view.PopulateMonthlySalesChart(monthlySales);
        }

        private async Task LoadAndPopulateWorstSellersYearChart()
        {
            // Calculate the worst sellers by year
            var worstSellers = await model.CalculateWorstSellersbyYear();

            // Populate the worst sellers by year chart in the view
            view.PopulateWorstSellersYearChart(worstSellers);
        }

        private async Task LoadAndPopulateBestSellersYearChart()
        {
            // Calculate the best sellers by year
            var bestSellers = await model.CalculateBestSellersYear();

            // Populate the best sellers by year chart in the view
            view.PopulateBestSellersYearChart(bestSellers);
        }

        private async Task LoadAndPopulateSalesbyWeekYearChart()
        {
            // Calculate the weekly sales by year
            var weeklySales = await model.SalesForEachWeekYear();

            // Populate the weekly sales by year chart in the view
            view.PopulateSalesbyWeekYearChart(weeklySales);
        }

        private async Task LoadAndPopulateMostProfitableProductsChart()
        {
            // Calculate the most profitable products
            var mostProfitableProducts = await model.MostProfitableProducts(5); // Adjust 'n' as needed

            // Populate the most profitable products chart in the view
            view.PopulateMostProfitableProductsChart(mostProfitableProducts);
        }

        private void DownloadReport()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx"; // Set the file filter to Excel files
                saveFileDialog.Title = "Save Report"; // Dialog title
                saveFileDialog.DefaultExt = "xlsx"; // Default file extension
                saveFileDialog.AddExtension = true; // Automatically add the file extension

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Generate and save the report to the selected file path
                    GenerateExcelReport(filePath);

                    // Optionally, you can show a confirmation message
                    MessageBox.Show("Report saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public async void GenerateExcelReport(string filePath)
        {
            try
            {
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Reports");

                    // Define column headers
                    var headers = new List<string>
            {
                "Report Name",
                "Value"
            };

                    for (int i = 1; i <= headers.Count; i++)
                    {
                        worksheet.Cells[1, i].Value = headers[i - 1];
                        worksheet.Cells[1, i].Style.Font.Bold = true;
                    }

                    int row = 2;

                    // Add your reports to the Excel file
                    worksheet.Cells[row, 1].Value = "Total Sales Revenue";
                    worksheet.Cells[row, 2].Value = await model.CalculateTotalSalesThisYear();
                    row++;

                    worksheet.Cells[row, 1].Value = "Total Gross Profit";
                    worksheet.Cells[row, 2].Value = await model.CalculateTotalGrossProfitYear();
                    row++;

                    worksheet.Cells[row, 1].Value = "Total Gross Margin";
                    worksheet.Cells[row, 2].Value = await model.CalculateTotalGrossProfitMarginYear();
                    row++;

                    worksheet.Cells[row, 1].Value = "Total Net Profit";
                    worksheet.Cells[row, 2].Value = await model.CalculateNetProfit();
                    row++;

                    worksheet.Cells[row, 1].Value = "Total Net Profit Margin";
                    worksheet.Cells[row, 2].Value = await model.CalculateNetProfitMargin();
                    row++;

                    // Create a directory to store chart images
                    string chartImagesDirectory = "ChartImages";
                    Directory.CreateDirectory(chartImagesDirectory);

                    // Capture chart images and add them to the report
                    AddChartImagesToReport(chartImagesDirectory, view, worksheet);

                    // Save the Excel file to the specified file path
                    File.WriteAllBytes(filePath, package.GetAsByteArray());
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur while generating the report
                Console.WriteLine("Error generating Excel report: " + ex.Message);
            }
        }

        private void AddChartImagesToReport(string imageDirectory, ReportsView view, ExcelWorksheet worksheet)
        {
            // Make sure you add references to System.Drawing.Common and System.Windows.Forms

            // Replace with your chart names or identifiers
            string[] chartNames = { "MonthlySalesChart", "worstSellersYear", "bestSellersYear", "SalesbyWeekYear", "mostProfiableProducts" };

            int imageRow = 5;
            int imageColumn = 4;

            foreach (var chartName in chartNames)
            {
                // Capture chart image
                byte[] chartImageBytes = CaptureChartImage(view, chartName);

                if (chartImageBytes != null)
                {
                    // Create an image in Excel
                    var picture = worksheet.Drawings.AddPicture(chartName, new MemoryStream(chartImageBytes));
                    picture.SetPosition(imageRow, 0, imageColumn, 0);
                    picture.SetSize(400, 300);

                    // Increment row and column for the next image
                    imageRow += 15; // Adjust as needed
                }
            }
        }

        private byte[] CaptureChartImage(ReportsView view, string chartName)
        {
          
            Chart chart = view.Controls.Find(chartName, true).FirstOrDefault() as Chart;

            if (chart != null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    chart.SaveImage(stream, ImageFormat.Png);
                    return stream.ToArray();
                }
            }

            return null;
        }


    }



}

