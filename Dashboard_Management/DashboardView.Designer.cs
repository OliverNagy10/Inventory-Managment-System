
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardView));
            this.label1 = new System.Windows.Forms.Label();
            this.inventoryValueLabel = new System.Windows.Forms.Label();
            this.runningLowLabel = new System.Windows.Forms.Label();
            this.monthSalesTotal = new System.Windows.Forms.Label();
            this.inventoryValueHolder = new System.Windows.Forms.Label();
            this.totalSalesHolder = new System.Windows.Forms.Label();
            this.BarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backButton = new System.Windows.Forms.Button();
            this.productMangementButton = new System.Windows.Forms.Button();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            this.LowProductsListView = new System.Windows.Forms.ListView();
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // inventoryValueLabel
            // 
            this.inventoryValueLabel.AutoSize = true;
            this.inventoryValueLabel.Location = new System.Drawing.Point(51, 26);
            this.inventoryValueLabel.Name = "inventoryValueLabel";
            this.inventoryValueLabel.Size = new System.Drawing.Size(150, 17);
            this.inventoryValueLabel.TabIndex = 1;
            this.inventoryValueLabel.Text = "Value of Inventory: ";
            // 
            // runningLowLabel
            // 
            this.runningLowLabel.AutoSize = true;
            this.runningLowLabel.Location = new System.Drawing.Point(73, 71);
            this.runningLowLabel.Name = "runningLowLabel";
            this.runningLowLabel.Size = new System.Drawing.Size(187, 17);
            this.runningLowLabel.TabIndex = 2;
            this.runningLowLabel.Text = "Products With Low Stock";
            // 
            // monthSalesTotal
            // 
            this.monthSalesTotal.AutoSize = true;
            this.monthSalesTotal.Location = new System.Drawing.Point(51, 277);
            this.monthSalesTotal.Name = "monthSalesTotal";
            this.monthSalesTotal.Size = new System.Drawing.Size(170, 17);
            this.monthSalesTotal.TabIndex = 3;
            this.monthSalesTotal.Text = "Total Sales this month";
            // 
            // inventoryValueHolder
            // 
            this.inventoryValueHolder.AutoSize = true;
            this.inventoryValueHolder.Location = new System.Drawing.Point(230, 26);
            this.inventoryValueHolder.Name = "inventoryValueHolder";
            this.inventoryValueHolder.Size = new System.Drawing.Size(40, 17);
            this.inventoryValueHolder.TabIndex = 5;
            this.inventoryValueHolder.Text = "$0.0";
            // 
            // totalSalesHolder
            // 
            this.totalSalesHolder.AutoSize = true;
            this.totalSalesHolder.Location = new System.Drawing.Point(230, 277);
            this.totalSalesHolder.Name = "totalSalesHolder";
            this.totalSalesHolder.Size = new System.Drawing.Size(40, 17);
            this.totalSalesHolder.TabIndex = 7;
            this.totalSalesHolder.Text = "$0.0";
            // 
            // BarChart
            // 
            chartArea1.Name = "ChartArea1";
            this.BarChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BarChart.Legends.Add(legend1);
            this.BarChart.Location = new System.Drawing.Point(305, 379);
            this.BarChart.Name = "BarChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.BarChart.Series.Add(series1);
            this.BarChart.Size = new System.Drawing.Size(406, 311);
            this.BarChart.TabIndex = 8;
            this.BarChart.Text = "chart1";
            // 
            // LineChart
            // 
            this.LineChart.BackColor = System.Drawing.Color.Crimson;
            this.LineChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            this.LineChart.BorderlineColor = System.Drawing.Color.Black;
            this.LineChart.BorderSkin.BackColor = System.Drawing.Color.Maroon;
            this.LineChart.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.LineChart.BorderSkin.BorderColor = System.Drawing.Color.Maroon;
            this.LineChart.BorderSkin.PageColor = System.Drawing.Color.Maroon;
            chartArea2.Name = "ChartArea1";
            this.LineChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.LineChart.Legends.Add(legend2);
            this.LineChart.Location = new System.Drawing.Point(765, 13);
            this.LineChart.Name = "LineChart";
            this.LineChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.LineChart.Series.Add(series2);
            this.LineChart.Size = new System.Drawing.Size(633, 330);
            this.LineChart.TabIndex = 10;
            this.LineChart.Text = "chart1";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(18, 678);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(109, 31);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Log Out";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // productMangementButton
            // 
            this.productMangementButton.Location = new System.Drawing.Point(364, 71);
            this.productMangementButton.Name = "productMangementButton";
            this.productMangementButton.Size = new System.Drawing.Size(289, 32);
            this.productMangementButton.TabIndex = 12;
            this.productMangementButton.Text = "Product and Stock Management ";
            this.productMangementButton.UseVisualStyleBackColor = true;
            // 
            // checkOutButton
            // 
            this.checkOutButton.Location = new System.Drawing.Point(364, 26);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(213, 32);
            this.checkOutButton.TabIndex = 14;
            this.checkOutButton.Text = "Checkout";
            this.checkOutButton.UseVisualStyleBackColor = true;
            // 
            // reportsButton
            // 
            this.reportsButton.Location = new System.Drawing.Point(364, 123);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(213, 35);
            this.reportsButton.TabIndex = 15;
            this.reportsButton.Text = "Analytics and Reports";
            this.reportsButton.UseVisualStyleBackColor = true;
            // 
            // LowProductsListView
            // 
            this.LowProductsListView.HideSelection = false;
            this.LowProductsListView.Location = new System.Drawing.Point(54, 102);
            this.LowProductsListView.Name = "LowProductsListView";
            this.LowProductsListView.Size = new System.Drawing.Size(216, 97);
            this.LowProductsListView.TabIndex = 16;
            this.LowProductsListView.UseCompatibleStateImageBehavior = false;
            this.LowProductsListView.View = System.Windows.Forms.View.List;
            // 
            // PieChart
            // 
            chartArea3.Name = "ChartArea1";
            this.PieChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.PieChart.Legends.Add(legend3);
            this.PieChart.Location = new System.Drawing.Point(765, 358);
            this.PieChart.Name = "PieChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.PieChart.Series.Add(series3);
            this.PieChart.Size = new System.Drawing.Size(633, 323);
            this.PieChart.TabIndex = 17;
            this.PieChart.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::Inventory_Managment_System.Properties.Resources.loading;
            this.pictureBox1.Location = new System.Drawing.Point(471, 201);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 276);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PieChart);
            this.Controls.Add(this.LowProductsListView);
            this.Controls.Add(this.reportsButton);
            this.Controls.Add(this.checkOutButton);
            this.Controls.Add(this.productMangementButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.LineChart);
            this.Controls.Add(this.BarChart);
            this.Controls.Add(this.totalSalesHolder);
            this.Controls.Add(this.inventoryValueHolder);
            this.Controls.Add(this.monthSalesTotal);
            this.Controls.Add(this.runningLowLabel);
            this.Controls.Add(this.inventoryValueLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(2160, 1080);
            this.Load += new System.EventHandler(this.DashboardView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label inventoryValueLabel;
        private System.Windows.Forms.Label runningLowLabel;
        private System.Windows.Forms.Label monthSalesTotal;
        private System.Windows.Forms.Label inventoryValueHolder;
        private System.Windows.Forms.Label totalSalesHolder;
        private System.Windows.Forms.DataVisualization.Charting.Chart BarChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart LineChart;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button productMangementButton;
        private System.Windows.Forms.Button checkOutButton;
        private System.Windows.Forms.Button reportsButton;
        private System.Windows.Forms.ListView LowProductsListView;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
