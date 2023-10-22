
namespace Inventory_Managment_System.Dashboard
{
    partial class DashboardView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.inventoryValueLabel = new System.Windows.Forms.Label();
            this.runningLowLabel = new System.Windows.Forms.Label();
            this.monthSalesTotal = new System.Windows.Forms.Label();
            this.inventoryValueHolder = new System.Windows.Forms.Label();
            this.runningLowHolder = new System.Windows.Forms.Label();
            this.totalSalesHolder = new System.Windows.Forms.Label();
            this.BarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backButton = new System.Windows.Forms.Button();
            this.productMangementButton = new System.Windows.Forms.Button();
            this.stockTrackingButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // inventoryValueLabel
            // 
            this.inventoryValueLabel.AutoSize = true;
            this.inventoryValueLabel.Location = new System.Drawing.Point(45, 26);
            this.inventoryValueLabel.Name = "inventoryValueLabel";
            this.inventoryValueLabel.Size = new System.Drawing.Size(130, 17);
            this.inventoryValueLabel.TabIndex = 1;
            this.inventoryValueLabel.Text = "Value of Inventory: ";
            // 
            // runningLowLabel
            // 
            this.runningLowLabel.AutoSize = true;
            this.runningLowLabel.Location = new System.Drawing.Point(45, 67);
            this.runningLowLabel.Name = "runningLowLabel";
            this.runningLowLabel.Size = new System.Drawing.Size(113, 17);
            this.runningLowLabel.TabIndex = 2;
            this.runningLowLabel.Text = "Running low on: ";
            // 
            // monthSalesTotal
            // 
            this.monthSalesTotal.AutoSize = true;
            this.monthSalesTotal.Location = new System.Drawing.Point(45, 107);
            this.monthSalesTotal.Name = "monthSalesTotal";
            this.monthSalesTotal.Size = new System.Drawing.Size(148, 17);
            this.monthSalesTotal.TabIndex = 3;
            this.monthSalesTotal.Text = "Total Sales this month";
            // 
            // inventoryValueHolder
            // 
            this.inventoryValueHolder.AutoSize = true;
            this.inventoryValueHolder.Location = new System.Drawing.Point(204, 26);
            this.inventoryValueHolder.Name = "inventoryValueHolder";
            this.inventoryValueHolder.Size = new System.Drawing.Size(16, 17);
            this.inventoryValueHolder.TabIndex = 5;
            this.inventoryValueHolder.Text = "$";
            // 
            // runningLowHolder
            // 
            this.runningLowHolder.AutoSize = true;
            this.runningLowHolder.Location = new System.Drawing.Point(173, 67);
            this.runningLowHolder.Name = "runningLowHolder";
            this.runningLowHolder.Size = new System.Drawing.Size(72, 17);
            this.runningLowHolder.TabIndex = 6;
            this.runningLowHolder.Text = "Coca Cola";
            // 
            // totalSalesHolder
            // 
            this.totalSalesHolder.AutoSize = true;
            this.totalSalesHolder.Location = new System.Drawing.Point(207, 107);
            this.totalSalesHolder.Name = "totalSalesHolder";
            this.totalSalesHolder.Size = new System.Drawing.Size(16, 17);
            this.totalSalesHolder.TabIndex = 7;
            this.totalSalesHolder.Text = "£";
            // 
            // BarChart
            // 
            chartArea4.Name = "ChartArea1";
            this.BarChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.BarChart.Legends.Add(legend4);
            this.BarChart.Location = new System.Drawing.Point(16, 542);
            this.BarChart.Name = "BarChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.BarChart.Series.Add(series4);
            this.BarChart.Size = new System.Drawing.Size(361, 311);
            this.BarChart.TabIndex = 8;
            this.BarChart.Text = "chart1";
            // 
            // PieChart
            // 
            chartArea5.Name = "ChartArea1";
            this.PieChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.PieChart.Legends.Add(legend5);
            this.PieChart.Location = new System.Drawing.Point(396, 542);
            this.PieChart.Name = "PieChart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.PieChart.Series.Add(series5);
            this.PieChart.Size = new System.Drawing.Size(515, 311);
            this.PieChart.TabIndex = 9;
            this.PieChart.Text = "chart1";
            // 
            // LineChart
            // 
            chartArea6.Name = "ChartArea1";
            this.LineChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.LineChart.Legends.Add(legend6);
            this.LineChart.Location = new System.Drawing.Point(946, 542);
            this.LineChart.Name = "LineChart";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.LineChart.Series.Add(series6);
            this.LineChart.Size = new System.Drawing.Size(490, 311);
            this.LineChart.TabIndex = 10;
            this.LineChart.Text = "chart1";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(16, 488);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(97, 31);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Log Out";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // productMangementButton
            // 
            this.productMangementButton.Location = new System.Drawing.Point(531, 26);
            this.productMangementButton.Name = "productMangementButton";
            this.productMangementButton.Size = new System.Drawing.Size(316, 32);
            this.productMangementButton.TabIndex = 12;
            this.productMangementButton.Text = "Product and Stock Management ";
            this.productMangementButton.UseVisualStyleBackColor = true;
            this.productMangementButton.Click += new System.EventHandler(this.productMangementButton_Click);
            // 
            // stockTrackingButton
            // 
            this.stockTrackingButton.Location = new System.Drawing.Point(324, 26);
            this.stockTrackingButton.Name = "stockTrackingButton";
            this.stockTrackingButton.Size = new System.Drawing.Size(189, 32);
            this.stockTrackingButton.TabIndex = 14;
            this.stockTrackingButton.Text = "Checkout";
            this.stockTrackingButton.UseVisualStyleBackColor = true;
            this.stockTrackingButton.Click += new System.EventHandler(this.Checkout_Click);
            // 
            // reportsButton
            // 
            this.reportsButton.Location = new System.Drawing.Point(881, 26);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(189, 35);
            this.reportsButton.TabIndex = 15;
            this.reportsButton.Text = "Sales Reports";
            this.reportsButton.UseVisualStyleBackColor = true;
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportsButton);
            this.Controls.Add(this.stockTrackingButton);
            this.Controls.Add(this.productMangementButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.LineChart);
            this.Controls.Add(this.PieChart);
            this.Controls.Add(this.BarChart);
            this.Controls.Add(this.totalSalesHolder);
            this.Controls.Add(this.runningLowHolder);
            this.Controls.Add(this.inventoryValueHolder);
            this.Controls.Add(this.monthSalesTotal);
            this.Controls.Add(this.runningLowLabel);
            this.Controls.Add(this.inventoryValueLabel);
            this.Controls.Add(this.label1);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label inventoryValueLabel;
        private System.Windows.Forms.Label runningLowLabel;
        private System.Windows.Forms.Label monthSalesTotal;
        private System.Windows.Forms.Label inventoryValueHolder;
        private System.Windows.Forms.Label runningLowHolder;
        private System.Windows.Forms.Label totalSalesHolder;
        private System.Windows.Forms.DataVisualization.Charting.Chart BarChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart LineChart;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button productMangementButton;
        private System.Windows.Forms.Button stockTrackingButton;
        private System.Windows.Forms.Button reportsButton;
    }
}
