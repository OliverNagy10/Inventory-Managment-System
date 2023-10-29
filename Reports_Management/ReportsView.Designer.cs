
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.monthlySales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.exitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.SalesbyWeek = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SalesLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
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
            ((System.ComponentModel.ISupportInitialize)(this.monthlySales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worstSellersYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestSellersYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostProfiableProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesbyWeek)).BeginInit();
            this.SuspendLayout();
            // 
            // monthlySales
            // 
            chartArea6.Name = "ChartArea1";
            this.monthlySales.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.monthlySales.Legends.Add(legend6);
            this.monthlySales.Location = new System.Drawing.Point(977, 380);
            this.monthlySales.Name = "monthlySales";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.monthlySales.Series.Add(series6);
            this.monthlySales.Size = new System.Drawing.Size(300, 300);
            this.monthlySales.TabIndex = 0;
            this.monthlySales.Text = "Montly Sales Chart";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(791, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Download Report";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // worstSellersYear
            // 
            chartArea7.Name = "ChartArea1";
            this.worstSellersYear.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.worstSellersYear.Legends.Add(legend7);
            this.worstSellersYear.Location = new System.Drawing.Point(674, 380);
            this.worstSellersYear.Name = "worstSellersYear";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.worstSellersYear.Series.Add(series7);
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
            chartArea8.Name = "ChartArea1";
            this.bestSellersYear.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.bestSellersYear.Legends.Add(legend8);
            this.bestSellersYear.Location = new System.Drawing.Point(359, 380);
            this.bestSellersYear.Name = "bestSellersYear";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.bestSellersYear.Series.Add(series8);
            this.bestSellersYear.Size = new System.Drawing.Size(300, 300);
            this.bestSellersYear.TabIndex = 14;
            this.bestSellersYear.Text = "chart1";
            // 
            // mostProfiableProducts
            // 
            chartArea9.Name = "ChartArea1";
            this.mostProfiableProducts.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.mostProfiableProducts.Legends.Add(legend9);
            this.mostProfiableProducts.Location = new System.Drawing.Point(32, 39);
            this.mostProfiableProducts.Name = "mostProfiableProducts";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.mostProfiableProducts.Series.Add(series9);
            this.mostProfiableProducts.Size = new System.Drawing.Size(300, 300);
            this.mostProfiableProducts.TabIndex = 15;
            this.mostProfiableProducts.Text = "chart1";
            // 
            // SalesbyWeek
            // 
            chartArea10.Name = "ChartArea1";
            this.SalesbyWeek.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.SalesbyWeek.Legends.Add(legend10);
            this.SalesbyWeek.Location = new System.Drawing.Point(32, 380);
            this.SalesbyWeek.Name = "SalesbyWeek";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.SalesbyWeek.Series.Add(series10);
            this.SalesbyWeek.Size = new System.Drawing.Size(300, 300);
            this.SalesbyWeek.TabIndex = 16;
            this.SalesbyWeek.Text = "chart1";
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
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(602, 168);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(612, 186);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.SalesLabel);
            this.Controls.Add(this.SalesbyWeek);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.monthlySales);
            this.Name = "ReportsView";
            this.Size = new System.Drawing.Size(1879, 698);
            this.Load += new System.EventHandler(this.ReportsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monthlySales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worstSellersYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestSellersYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostProfiableProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesbyWeek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart monthlySales;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart SalesbyWeek;
        private System.Windows.Forms.Label SalesLabel;
        private System.Windows.Forms.ListView listView1;
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
