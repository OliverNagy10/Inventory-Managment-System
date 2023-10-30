
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardView));
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "PRODUCTS WITH LESS THAN 10 IN-STOCK ");
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.BarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.windows11DarkTheme1 = new Telerik.WinControls.Themes.Windows11DarkTheme();
            this.radApplicationMenu1 = new Telerik.WinControls.UI.RadApplicationMenu();
            this.MenuCheckout = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.MenuProduct = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenuSeparatorItem2 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.MenuReports = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenuSeparatorItem3 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.MenuLogout = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.inventorylabel = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.LowProductsListView = new Telerik.WinControls.UI.RadListView();
            this.LineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.totalSalesHolder = new Telerik.WinControls.UI.RadTextBox();
            this.inventoryValueHolder = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.salesValueHolder = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radApplicationMenu1)).BeginInit();
            this.radApplicationMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventorylabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowProductsListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSalesHolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryValueHolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesValueHolder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // BarChart
            // 
            this.BarChart.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.None;
            this.BarChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BarChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            this.BarChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BarChart.BorderlineColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.BarChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BarChart.Legends.Add(legend1);
            this.BarChart.Location = new System.Drawing.Point(1345, 577);
            this.BarChart.Name = "BarChart";
            this.BarChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.BarChart.Series.Add(series1);
            this.BarChart.Size = new System.Drawing.Size(580, 394);
            this.BarChart.TabIndex = 8;
            this.BarChart.Text = "chart1";
            this.BarChart.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            // 
            // PieChart
            // 
            this.PieChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PieChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            this.PieChart.BackSecondaryColor = System.Drawing.Color.Gray;
            this.PieChart.BorderSkin.BackColor = System.Drawing.Color.Maroon;
            this.PieChart.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.PieChart.BorderSkin.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkDownwardDiagonal;
            this.PieChart.BorderSkin.PageColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.PieChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.PieChart.Legends.Add(legend2);
            this.PieChart.Location = new System.Drawing.Point(759, 569);
            this.PieChart.Name = "PieChart";
            this.PieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.PieChart.Series.Add(series2);
            this.PieChart.Size = new System.Drawing.Size(580, 394);
            this.PieChart.TabIndex = 17;
            this.PieChart.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(838, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // radApplicationMenu1
            // 
            this.radApplicationMenu1.Controls.Add(this.radLabel2);
            this.radApplicationMenu1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radApplicationMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.MenuCheckout,
            this.radMenuSeparatorItem1,
            this.MenuProduct,
            this.radMenuSeparatorItem2,
            this.MenuReports,
            this.radMenuSeparatorItem3,
            this.MenuLogout});
            this.radApplicationMenu1.Location = new System.Drawing.Point(53, 24);
            this.radApplicationMenu1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.radApplicationMenu1.Name = "radApplicationMenu1";
            this.radApplicationMenu1.ShowTwoColumnDropDownMenu = false;
            this.radApplicationMenu1.Size = new System.Drawing.Size(334, 60);
            this.radApplicationMenu1.TabIndex = 20;
            this.radApplicationMenu1.Text = "radApplicationMenu1";
            this.radApplicationMenu1.ThemeName = "Windows11Dark";
            // 
            // MenuCheckout
            // 
            this.MenuCheckout.Name = "MenuCheckout";
            this.MenuCheckout.Text = "Checkout";
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuProduct
            // 
            this.MenuProduct.Name = "MenuProduct";
            this.MenuProduct.Text = "Product and Stock Management";
            // 
            // radMenuSeparatorItem2
            // 
            this.radMenuSeparatorItem2.Name = "radMenuSeparatorItem2";
            this.radMenuSeparatorItem2.Text = "radMenuSeparatorItem2";
            this.radMenuSeparatorItem2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuReports
            // 
            this.MenuReports.Name = "MenuReports";
            this.MenuReports.Text = "Analytics and Reports";
            // 
            // radMenuSeparatorItem3
            // 
            this.radMenuSeparatorItem3.Name = "radMenuSeparatorItem3";
            this.radMenuSeparatorItem3.Text = "radMenuSeparatorItem3";
            this.radMenuSeparatorItem3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuLogout
            // 
            this.MenuLogout.Name = "MenuLogout";
            this.MenuLogout.Text = "Log out";
            // 
            // inventorylabel
            // 
            this.inventorylabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventorylabel.AutoSize = false;
            this.inventorylabel.Location = new System.Drawing.Point(1587, 48);
            this.inventorylabel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.inventorylabel.Name = "inventorylabel";
            this.inventorylabel.Size = new System.Drawing.Size(144, 0);
            this.inventorylabel.TabIndex = 23;
            this.inventorylabel.Text = "INVENTORY VALUE";
            this.inventorylabel.ThemeName = "Windows11Dark";
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel1.AutoSize = false;
            this.radLabel1.Location = new System.Drawing.Point(893, 24);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(249, 0);
            this.radLabel1.TabIndex = 24;
            this.radLabel1.Text = "TOTAL SALES THIS MONTH";
            this.radLabel1.ThemeName = "Windows11Dark";
            // 
            // LowProductsListView
            // 
            listViewDetailColumn1.HeaderText = "PRODUCTS WITH LESS THAN 10 IN-STOCK ";
            listViewDetailColumn1.MinWidth = 125F;
            listViewDetailColumn1.Width = 330F;
            this.LowProductsListView.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1});
            this.LowProductsListView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LowProductsListView.GroupItemSize = new System.Drawing.Size(611, 31);
            this.LowProductsListView.HeaderHeight = 68.35938F;
            this.LowProductsListView.ItemSize = new System.Drawing.Size(250, 45);
            this.LowProductsListView.ItemSpacing = -1;
            this.LowProductsListView.Location = new System.Drawing.Point(833, 176);
            this.LowProductsListView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LowProductsListView.Name = "LowProductsListView";
            this.LowProductsListView.Size = new System.Drawing.Size(327, 142);
            this.LowProductsListView.TabIndex = 32;
            this.LowProductsListView.ThemeName = "Windows11Dark";
            this.LowProductsListView.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.LowProductsListView.SelectedItemChanged += new System.EventHandler(this.LowProductsListView_SelectedItemChanged);
            // 
            // LineChart
            // 
            this.LineChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LineChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            chartArea3.Name = "ChartArea1";
            this.LineChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.LineChart.Legends.Add(legend3);
            this.LineChart.Location = new System.Drawing.Point(53, 577);
            this.LineChart.Name = "LineChart";
            this.LineChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.LineChart.Series.Add(series3);
            this.LineChart.Size = new System.Drawing.Size(650, 394);
            this.LineChart.TabIndex = 33;
            this.LineChart.Text = "chart1";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel2.Location = new System.Drawing.Point(134, 24);
            this.radLabel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(68, 31);
            this.radLabel2.TabIndex = 34;
            this.radLabel2.Text = "MENU";
            this.radLabel2.ThemeName = "Windows11Dark";
            // 
            // totalSalesHolder
            // 
            this.totalSalesHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalSalesHolder.AutoSize = false;
            this.totalSalesHolder.Location = new System.Drawing.Point(893, 81);
            this.totalSalesHolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalSalesHolder.Name = "totalSalesHolder";
            this.totalSalesHolder.ReadOnly = true;
            this.totalSalesHolder.Size = new System.Drawing.Size(196, 0);
            this.totalSalesHolder.TabIndex = 36;
            this.totalSalesHolder.ThemeName = "Windows11Dark";
            // 
            // inventoryValueHolder
            // 
            this.inventoryValueHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryValueHolder.Location = new System.Drawing.Point(784, 41);
            this.inventoryValueHolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inventoryValueHolder.Name = "inventoryValueHolder";
            this.inventoryValueHolder.ReadOnly = true;
            this.inventoryValueHolder.Size = new System.Drawing.Size(132, 40);
            this.inventoryValueHolder.TabIndex = 37;
            this.inventoryValueHolder.ThemeName = "Windows11Dark";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel3.Location = new System.Drawing.Point(53, 451);
            this.radLabel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(170, 31);
            this.radLabel3.TabIndex = 38;
            this.radLabel3.Text = "SALES THIS WEEK";
            this.radLabel3.ThemeName = "Windows11Dark";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel4.Location = new System.Drawing.Point(698, 451);
            this.radLabel4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(391, 31);
            this.radLabel4.TabIndex = 39;
            this.radLabel4.Text = "TOP 3 PRODUCTS THIS MONTH BY UNITS";
            this.radLabel4.ThemeName = "Windows11Dark";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel5.Location = new System.Drawing.Point(1371, 437);
            this.radLabel5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(420, 31);
            this.radLabel5.TabIndex = 40;
            this.radLabel5.Text = "TOP 3 PRODUCTS THIS MONTH BY REVENUE";
            this.radLabel5.ThemeName = "Windows11Dark";
            // 
            // salesValueHolder
            // 
            this.salesValueHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salesValueHolder.Location = new System.Drawing.Point(477, 39);
            this.salesValueHolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salesValueHolder.Name = "salesValueHolder";
            this.salesValueHolder.Size = new System.Drawing.Size(183, 40);
            this.salesValueHolder.TabIndex = 0;
            this.salesValueHolder.ThemeName = "Windows11Dark";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.salesValueHolder);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.inventoryValueHolder);
            this.Controls.Add(this.totalSalesHolder);
            this.Controls.Add(this.LineChart);
            this.Controls.Add(this.LowProductsListView);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.inventorylabel);
            this.Controls.Add(this.radApplicationMenu1);
            this.Controls.Add(this.PieChart);
            this.Controls.Add(this.BarChart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("MT Extra", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(1902, 1033);
            this.Load += new System.EventHandler(this.DashboardView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radApplicationMenu1)).EndInit();
            this.radApplicationMenu1.ResumeLayout(false);
            this.radApplicationMenu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventorylabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowProductsListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSalesHolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryValueHolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesValueHolder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart BarChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.Themes.Windows11DarkTheme windows11DarkTheme1;
        private Telerik.WinControls.UI.RadMenuButtonItem MenuCheckout;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.UI.RadMenuButtonItem MenuProduct;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem2;
        private Telerik.WinControls.UI.RadMenuButtonItem MenuReports;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem3;
        private Telerik.WinControls.UI.RadMenuButtonItem MenuLogout;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel inventorylabel;
        private Telerik.WinControls.UI.RadListView LowProductsListView;
        private System.Windows.Forms.DataVisualization.Charting.Chart LineChart;
        private Telerik.WinControls.UI.RadApplicationMenu radApplicationMenu1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox totalSalesHolder;
        private Telerik.WinControls.UI.RadTextBox inventoryValueHolder;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadTextBox salesValueHolder;
    }
}
