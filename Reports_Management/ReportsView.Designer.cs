﻿
namespace Inventory_Managment_System.Reports_Management
{
    partial class ReportsView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.monthlySalesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.exitButton = new System.Windows.Forms.Button();
            this.downloadReportButton = new System.Windows.Forms.Button();
            this.worstSellersYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.salesRevenueLabel = new System.Windows.Forms.Label();
            this.GrossRevenueLabel = new System.Windows.Forms.Label();
            this.netProfitMarginLabel = new System.Windows.Forms.Label();
            this.netProfitMarginHolder = new System.Windows.Forms.Label();
            this.grossProfitHolder = new System.Windows.Forms.Label();
            this.SalesRevenueHolder = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.bestSellersYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mostProfiableProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SalesbyWeekYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SalesLabel = new System.Windows.Forms.Label();
            this.SalesListView = new System.Windows.Forms.ListView();
            this.GrossMarginLabel = new System.Windows.Forms.Label();
            this.grossMarginHolder = new System.Windows.Forms.Label();
            this.ExpenseLabel = new System.Windows.Forms.Label();
            this.expenseListView = new System.Windows.Forms.ListView();
            this.deleteExpenseButton = new System.Windows.Forms.Button();
            this.addExpenseButton = new System.Windows.Forms.Button();
            this.expenseNameTextBox = new System.Windows.Forms.TextBox();
            this.ExpenseAmountTextBox = new System.Windows.Forms.TextBox();
            this.ExpenseNameLabel = new System.Windows.Forms.Label();
            this.ExpenseAmountLabel = new System.Windows.Forms.Label();
            this.DateOfExpneseLabel = new System.Windows.Forms.Label();
            this.dateOfExpenseTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.NetProfitLabel = new System.Windows.Forms.Label();
            this.NetProfitHolder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.monthlySalesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worstSellersYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestSellersYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostProfiableProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesbyWeekYear)).BeginInit();
            this.SuspendLayout();
            // 
            // monthlySalesChart
            // 
            chartArea1.Name = "ChartArea1";
            this.monthlySalesChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.monthlySalesChart.Legends.Add(legend1);
            this.monthlySalesChart.Location = new System.Drawing.Point(977, 380);
            this.monthlySalesChart.Name = "monthlySalesChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.monthlySalesChart.Series.Add(series1);
            this.monthlySalesChart.Size = new System.Drawing.Size(300, 300);
            this.monthlySalesChart.TabIndex = 0;
            this.monthlySalesChart.Text = "Montly Sales Chart";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1202, 20);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // downloadReportButton
            // 
            this.downloadReportButton.Location = new System.Drawing.Point(791, 20);
            this.downloadReportButton.Name = "downloadReportButton";
            this.downloadReportButton.Size = new System.Drawing.Size(180, 23);
            this.downloadReportButton.TabIndex = 2;
            this.downloadReportButton.Text = "Download Report";
            this.downloadReportButton.UseVisualStyleBackColor = true;
            // 
            // worstSellersYear
            // 
            chartArea2.Name = "ChartArea1";
            this.worstSellersYear.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.worstSellersYear.Legends.Add(legend2);
            this.worstSellersYear.Location = new System.Drawing.Point(674, 380);
            this.worstSellersYear.Name = "worstSellersYear";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.worstSellersYear.Series.Add(series2);
            this.worstSellersYear.Size = new System.Drawing.Size(297, 300);
            this.worstSellersYear.TabIndex = 6;
            this.worstSellersYear.Text = "chart2";
            // 
            // salesRevenueLabel
            // 
            this.salesRevenueLabel.AutoSize = true;
            this.salesRevenueLabel.Location = new System.Drawing.Point(356, 115);
            this.salesRevenueLabel.Name = "salesRevenueLabel";
            this.salesRevenueLabel.Size = new System.Drawing.Size(140, 17);
            this.salesRevenueLabel.TabIndex = 7;
            this.salesRevenueLabel.Text = "Total Sales Revenue";
            // 
            // GrossRevenueLabel
            // 
            this.GrossRevenueLabel.AutoSize = true;
            this.GrossRevenueLabel.Location = new System.Drawing.Point(356, 155);
            this.GrossRevenueLabel.Name = "GrossRevenueLabel";
            this.GrossRevenueLabel.Size = new System.Drawing.Size(83, 17);
            this.GrossRevenueLabel.TabIndex = 8;
            this.GrossRevenueLabel.Text = "Gross Profit";
            // 
            // netProfitMarginLabel
            // 
            this.netProfitMarginLabel.AutoSize = true;
            this.netProfitMarginLabel.Location = new System.Drawing.Point(356, 256);
            this.netProfitMarginLabel.Name = "netProfitMarginLabel";
            this.netProfitMarginLabel.Size = new System.Drawing.Size(114, 17);
            this.netProfitMarginLabel.TabIndex = 9;
            this.netProfitMarginLabel.Text = "Net Profit Margin";
            // 
            // netProfitMarginHolder
            // 
            this.netProfitMarginHolder.AutoSize = true;
            this.netProfitMarginHolder.Location = new System.Drawing.Point(486, 256);
            this.netProfitMarginHolder.Name = "netProfitMarginHolder";
            this.netProfitMarginHolder.Size = new System.Drawing.Size(28, 17);
            this.netProfitMarginHolder.TabIndex = 10;
            this.netProfitMarginHolder.Text = "0.0";
            // 
            // grossProfitHolder
            // 
            this.grossProfitHolder.AutoSize = true;
            this.grossProfitHolder.Location = new System.Drawing.Point(486, 155);
            this.grossProfitHolder.Name = "grossProfitHolder";
            this.grossProfitHolder.Size = new System.Drawing.Size(28, 17);
            this.grossProfitHolder.TabIndex = 11;
            this.grossProfitHolder.Text = "0.0";
            // 
            // SalesRevenueHolder
            // 
            this.SalesRevenueHolder.AutoSize = true;
            this.SalesRevenueHolder.Location = new System.Drawing.Point(498, 115);
            this.SalesRevenueHolder.Name = "SalesRevenueHolder";
            this.SalesRevenueHolder.Size = new System.Drawing.Size(28, 17);
            this.SalesRevenueHolder.TabIndex = 12;
            this.SalesRevenueHolder.Text = "0.0";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLabel.Location = new System.Drawing.Point(582, 12);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(173, 29);
            this.YearLabel.TabIndex = 13;
            this.YearLabel.Text = "Yearly Report ";
            // 
            // bestSellersYear
            // 
            chartArea3.Name = "ChartArea1";
            this.bestSellersYear.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.bestSellersYear.Legends.Add(legend3);
            this.bestSellersYear.Location = new System.Drawing.Point(359, 380);
            this.bestSellersYear.Name = "bestSellersYear";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.bestSellersYear.Series.Add(series3);
            this.bestSellersYear.Size = new System.Drawing.Size(300, 300);
            this.bestSellersYear.TabIndex = 14;
            this.bestSellersYear.Text = "chart1";
            // 
            // mostProfiableProducts
            // 
            chartArea4.Name = "ChartArea1";
            this.mostProfiableProducts.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.mostProfiableProducts.Legends.Add(legend4);
            this.mostProfiableProducts.Location = new System.Drawing.Point(32, 39);
            this.mostProfiableProducts.Name = "mostProfiableProducts";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.mostProfiableProducts.Series.Add(series4);
            this.mostProfiableProducts.Size = new System.Drawing.Size(300, 300);
            this.mostProfiableProducts.TabIndex = 15;
            this.mostProfiableProducts.Text = "chart1";
            // 
            // SalesbyWeekYear
            // 
            chartArea5.Name = "ChartArea1";
            this.SalesbyWeekYear.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.SalesbyWeekYear.Legends.Add(legend5);
            this.SalesbyWeekYear.Location = new System.Drawing.Point(32, 380);
            this.SalesbyWeekYear.Name = "SalesbyWeekYear";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.SalesbyWeekYear.Series.Add(series5);
            this.SalesbyWeekYear.Size = new System.Drawing.Size(300, 300);
            this.SalesbyWeekYear.TabIndex = 16;
            this.SalesbyWeekYear.Text = "chart1";
            // 
            // SalesLabel
            // 
            this.SalesLabel.AutoSize = true;
            this.SalesLabel.Location = new System.Drawing.Point(638, 95);
            this.SalesLabel.Name = "SalesLabel";
            this.SalesLabel.Size = new System.Drawing.Size(43, 17);
            this.SalesLabel.TabIndex = 17;
            this.SalesLabel.Text = "Sales";
            // 
            // SalesListView
            // 
            this.SalesListView.HideSelection = false;
            this.SalesListView.Location = new System.Drawing.Point(608, 168);
            this.SalesListView.Name = "SalesListView";
            this.SalesListView.Size = new System.Drawing.Size(612, 186);
            this.SalesListView.TabIndex = 18;
            this.SalesListView.UseCompatibleStateImageBehavior = false;
            // 
            // GrossMarginLabel
            // 
            this.GrossMarginLabel.AutoSize = true;
            this.GrossMarginLabel.Location = new System.Drawing.Point(359, 186);
            this.GrossMarginLabel.Name = "GrossMarginLabel";
            this.GrossMarginLabel.Size = new System.Drawing.Size(93, 17);
            this.GrossMarginLabel.TabIndex = 21;
            this.GrossMarginLabel.Text = "Gross Margin";
            // 
            // grossMarginHolder
            // 
            this.grossMarginHolder.AutoSize = true;
            this.grossMarginHolder.Location = new System.Drawing.Point(489, 186);
            this.grossMarginHolder.Name = "grossMarginHolder";
            this.grossMarginHolder.Size = new System.Drawing.Size(28, 17);
            this.grossMarginHolder.TabIndex = 22;
            this.grossMarginHolder.Text = "0.0";
            // 
            // ExpenseLabel
            // 
            this.ExpenseLabel.AutoSize = true;
            this.ExpenseLabel.Location = new System.Drawing.Point(1255, 95);
            this.ExpenseLabel.Name = "ExpenseLabel";
            this.ExpenseLabel.Size = new System.Drawing.Size(115, 17);
            this.ExpenseLabel.TabIndex = 23;
            this.ExpenseLabel.Text = "Expense Tracker";
            // 
            // expenseListView
            // 
            this.expenseListView.HideSelection = false;
            this.expenseListView.Location = new System.Drawing.Point(1258, 118);
            this.expenseListView.Name = "expenseListView";
            this.expenseListView.Size = new System.Drawing.Size(596, 186);
            this.expenseListView.TabIndex = 24;
            this.expenseListView.UseCompatibleStateImageBehavior = false;
            // 
            // deleteExpenseButton
            // 
            this.deleteExpenseButton.Location = new System.Drawing.Point(1463, 580);
            this.deleteExpenseButton.Name = "deleteExpenseButton";
            this.deleteExpenseButton.Size = new System.Drawing.Size(75, 23);
            this.deleteExpenseButton.TabIndex = 25;
            this.deleteExpenseButton.Text = "Delete";
            this.deleteExpenseButton.UseVisualStyleBackColor = true;
            // 
            // addExpenseButton
            // 
            this.addExpenseButton.Location = new System.Drawing.Point(1572, 580);
            this.addExpenseButton.Name = "addExpenseButton";
            this.addExpenseButton.Size = new System.Drawing.Size(73, 23);
            this.addExpenseButton.TabIndex = 26;
            this.addExpenseButton.Text = "Add";
            this.addExpenseButton.UseVisualStyleBackColor = true;
            // 
            // expenseNameTextBox
            // 
            this.expenseNameTextBox.Location = new System.Drawing.Point(1477, 410);
            this.expenseNameTextBox.Name = "expenseNameTextBox";
            this.expenseNameTextBox.Size = new System.Drawing.Size(194, 22);
            this.expenseNameTextBox.TabIndex = 27;
            // 
            // ExpenseAmountTextBox
            // 
            this.ExpenseAmountTextBox.Location = new System.Drawing.Point(1477, 482);
            this.ExpenseAmountTextBox.Name = "ExpenseAmountTextBox";
            this.ExpenseAmountTextBox.Size = new System.Drawing.Size(194, 22);
            this.ExpenseAmountTextBox.TabIndex = 28;
            // 
            // ExpenseNameLabel
            // 
            this.ExpenseNameLabel.AutoSize = true;
            this.ExpenseNameLabel.Location = new System.Drawing.Point(1333, 415);
            this.ExpenseNameLabel.Name = "ExpenseNameLabel";
            this.ExpenseNameLabel.Size = new System.Drawing.Size(107, 17);
            this.ExpenseNameLabel.TabIndex = 29;
            this.ExpenseNameLabel.Text = "Expense Name:";
            // 
            // ExpenseAmountLabel
            // 
            this.ExpenseAmountLabel.AutoSize = true;
            this.ExpenseAmountLabel.Location = new System.Drawing.Point(1333, 487);
            this.ExpenseAmountLabel.Name = "ExpenseAmountLabel";
            this.ExpenseAmountLabel.Size = new System.Drawing.Size(64, 17);
            this.ExpenseAmountLabel.TabIndex = 30;
            this.ExpenseAmountLabel.Text = "Amount: ";
            // 
            // DateOfExpneseLabel
            // 
            this.DateOfExpneseLabel.AutoSize = true;
            this.DateOfExpneseLabel.Location = new System.Drawing.Point(1344, 538);
            this.DateOfExpneseLabel.Name = "DateOfExpneseLabel";
            this.DateOfExpneseLabel.Size = new System.Drawing.Size(38, 17);
            this.DateOfExpneseLabel.TabIndex = 31;
            this.DateOfExpneseLabel.Text = "Date";
            // 
            // dateOfExpenseTextBox
            // 
            this.dateOfExpenseTextBox.Location = new System.Drawing.Point(1477, 538);
            this.dateOfExpenseTextBox.Name = "dateOfExpenseTextBox";
            this.dateOfExpenseTextBox.Size = new System.Drawing.Size(194, 22);
            this.dateOfExpenseTextBox.TabIndex = 32;
            this.dateOfExpenseTextBox.Text = "MM/dd/yyyy";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1697, 39);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 33;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(1495, 39);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(176, 22);
            this.searchBox.TabIndex = 34;
            // 
            // NetProfitLabel
            // 
            this.NetProfitLabel.AutoSize = true;
            this.NetProfitLabel.Location = new System.Drawing.Point(356, 222);
            this.NetProfitLabel.Name = "NetProfitLabel";
            this.NetProfitLabel.Size = new System.Drawing.Size(67, 17);
            this.NetProfitLabel.TabIndex = 35;
            this.NetProfitLabel.Text = "Net Profit";
            // 
            // NetProfitHolder
            // 
            this.NetProfitHolder.AutoSize = true;
            this.NetProfitHolder.Location = new System.Drawing.Point(489, 222);
            this.NetProfitHolder.Name = "NetProfitHolder";
            this.NetProfitHolder.Size = new System.Drawing.Size(28, 17);
            this.NetProfitHolder.TabIndex = 36;
            this.NetProfitHolder.Text = "0.0";
            // 
            // ReportsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NetProfitHolder);
            this.Controls.Add(this.NetProfitLabel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.dateOfExpenseTextBox);
            this.Controls.Add(this.DateOfExpneseLabel);
            this.Controls.Add(this.ExpenseAmountLabel);
            this.Controls.Add(this.ExpenseNameLabel);
            this.Controls.Add(this.ExpenseAmountTextBox);
            this.Controls.Add(this.expenseNameTextBox);
            this.Controls.Add(this.addExpenseButton);
            this.Controls.Add(this.deleteExpenseButton);
            this.Controls.Add(this.expenseListView);
            this.Controls.Add(this.ExpenseLabel);
            this.Controls.Add(this.grossMarginHolder);
            this.Controls.Add(this.GrossMarginLabel);
            this.Controls.Add(this.SalesListView);
            this.Controls.Add(this.SalesLabel);
            this.Controls.Add(this.SalesbyWeekYear);
            this.Controls.Add(this.mostProfiableProducts);
            this.Controls.Add(this.bestSellersYear);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.SalesRevenueHolder);
            this.Controls.Add(this.grossProfitHolder);
            this.Controls.Add(this.netProfitMarginHolder);
            this.Controls.Add(this.netProfitMarginLabel);
            this.Controls.Add(this.GrossRevenueLabel);
            this.Controls.Add(this.salesRevenueLabel);
            this.Controls.Add(this.worstSellersYear);
            this.Controls.Add(this.downloadReportButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.monthlySalesChart);
            this.Name = "ReportsView";
            this.Size = new System.Drawing.Size(1879, 698);
            this.Load += new System.EventHandler(this.ReportsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monthlySalesChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worstSellersYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestSellersYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostProfiableProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesbyWeekYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart monthlySalesChart;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button downloadReportButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart worstSellersYear;
        private System.Windows.Forms.Label salesRevenueLabel;
        private System.Windows.Forms.Label GrossRevenueLabel;
        private System.Windows.Forms.Label netProfitMarginLabel;
        private System.Windows.Forms.Label netProfitMarginHolder;
        private System.Windows.Forms.Label grossProfitHolder;
        private System.Windows.Forms.Label SalesRevenueHolder;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart bestSellersYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart mostProfiableProducts;
        private System.Windows.Forms.DataVisualization.Charting.Chart SalesbyWeekYear;
        private System.Windows.Forms.Label SalesLabel;
        private System.Windows.Forms.ListView SalesListView;
        private System.Windows.Forms.Label GrossMarginLabel;
        private System.Windows.Forms.Label grossMarginHolder;
        private System.Windows.Forms.Label ExpenseLabel;
        private System.Windows.Forms.ListView expenseListView;
        private System.Windows.Forms.Button deleteExpenseButton;
        private System.Windows.Forms.Button addExpenseButton;
        private System.Windows.Forms.TextBox expenseNameTextBox;
        private System.Windows.Forms.TextBox ExpenseAmountTextBox;
        private System.Windows.Forms.Label ExpenseNameLabel;
        private System.Windows.Forms.Label ExpenseAmountLabel;
        private System.Windows.Forms.Label DateOfExpneseLabel;
        private System.Windows.Forms.TextBox dateOfExpenseTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label NetProfitLabel;
        private System.Windows.Forms.Label NetProfitHolder;
    }
}
