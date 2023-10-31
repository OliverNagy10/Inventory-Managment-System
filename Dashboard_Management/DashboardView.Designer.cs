
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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "LOW PRODUCTS");
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.BarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.windows11DarkTheme1 = new Telerik.WinControls.Themes.Windows11DarkTheme();
            this.radApplicationMenu1 = new Telerik.WinControls.UI.RadApplicationMenu();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.MenuCheckout = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.MenuProduct = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenuSeparatorItem2 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.MenuReports = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenuSeparatorItem3 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.MenuLogout = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.LowProductsListView = new Telerik.WinControls.UI.RadListView();
            this.LineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.inventoryValueHolder = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.salesValueHolder = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radApplicationMenu1)).BeginInit();
            this.radApplicationMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowProductsListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryValueHolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesValueHolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 0;
            // 
            // BarChart
            // 
            this.BarChart.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.None;
            this.BarChart.BackColor = System.Drawing.Color.Transparent;
            this.BarChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BarChart.BorderlineColor = System.Drawing.Color.DimGray;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "ChartArea1";
            this.BarChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            legend1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BarChart.Legends.Add(legend1);
            this.BarChart.Location = new System.Drawing.Point(537, 454);
            this.BarChart.Margin = new System.Windows.Forms.Padding(2);
            this.BarChart.Name = "BarChart";
            this.BarChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.BarChart.Series.Add(series1);
            this.BarChart.Size = new System.Drawing.Size(552, 340);
            this.BarChart.TabIndex = 8;
            this.BarChart.Text = "chart1";
            this.BarChart.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            // 
            // PieChart
            // 
            this.PieChart.BackColor = System.Drawing.Color.Transparent;
            this.PieChart.BackSecondaryColor = System.Drawing.Color.Gray;
            this.PieChart.BorderSkin.BackColor = System.Drawing.Color.Maroon;
            this.PieChart.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.PieChart.BorderSkin.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkDownwardDiagonal;
            this.PieChart.BorderSkin.PageColor = System.Drawing.Color.Black;
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.Name = "ChartArea1";
            this.PieChart.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            legend2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.PieChart.Legends.Add(legend2);
            this.PieChart.Location = new System.Drawing.Point(1093, 454);
            this.PieChart.Margin = new System.Windows.Forms.Padding(2);
            this.PieChart.Name = "PieChart";
            this.PieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series2.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            series2.IsValueShownAsLabel = true;
            series2.LabelBackColor = System.Drawing.Color.Transparent;
            series2.LabelBorderColor = System.Drawing.Color.Transparent;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series2.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series2.MarkerImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series2.Name = "Series1";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.PieChart.Series.Add(series2);
            this.PieChart.Size = new System.Drawing.Size(435, 340);
            this.PieChart.TabIndex = 17;
            this.PieChart.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1540, 845);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // radApplicationMenu1
            // 
            this.radApplicationMenu1.BackColor = System.Drawing.Color.Transparent;
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
            this.radApplicationMenu1.Location = new System.Drawing.Point(20, 10);
            this.radApplicationMenu1.Margin = new System.Windows.Forms.Padding(10);
            this.radApplicationMenu1.Name = "radApplicationMenu1";
            this.radApplicationMenu1.ShowTwoColumnDropDownMenu = false;
            this.radApplicationMenu1.Size = new System.Drawing.Size(312, 66);
            this.radApplicationMenu1.TabIndex = 20;
            this.radApplicationMenu1.Text = "radApplicationMenu1";
            this.radApplicationMenu1.ThemeName = "Windows11Dark";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(0, 0);
            this.radLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(2, 2);
            this.radLabel2.TabIndex = 0;
            // 
            // MenuCheckout
            // 
            this.MenuCheckout.Name = "MenuCheckout";
            this.MenuCheckout.Text = "CHECKOUT";
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
            this.MenuProduct.Text = "PRODUCT AND STOCK MANAGEMENT";
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
            this.MenuReports.Text = "YEARLY ANALYTICS AND REPORTS";
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
            this.MenuLogout.Text = "LOG OUT";
            // 
            // LowProductsListView
            // 
            listViewDetailColumn1.HeaderText = "LOW PRODUCTS";
            listViewDetailColumn1.MinWidth = 156.25F;
            listViewDetailColumn1.Width = 400F;
            this.LowProductsListView.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1});
            this.LowProductsListView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LowProductsListView.GroupIndent = 31;
            this.LowProductsListView.GroupItemSize = new System.Drawing.Size(764, 39);
            this.LowProductsListView.HeaderHeight = 30F;
            this.LowProductsListView.ItemSize = new System.Drawing.Size(313, 30);
            this.LowProductsListView.ItemSpacing = -1;
            this.LowProductsListView.Location = new System.Drawing.Point(1103, 20);
            this.LowProductsListView.Margin = new System.Windows.Forms.Padding(8);
            this.LowProductsListView.Name = "LowProductsListView";
            this.LowProductsListView.Size = new System.Drawing.Size(398, 132);
            this.LowProductsListView.TabIndex = 32;
            this.LowProductsListView.ThemeName = "Windows11Dark";
            this.LowProductsListView.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.LowProductsListView.SelectedItemChanged += new System.EventHandler(this.LowProductsListView_SelectedItemChanged);
            // 
            // LineChart
            // 
            lineAnnotation1.LineColor = System.Drawing.Color.White;
            lineAnnotation1.Name = "LineAnnotation1";
            this.LineChart.Annotations.Add(lineAnnotation1);
            this.LineChart.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Area3DStyle.Enable3D = true;
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.BorderColor = System.Drawing.Color.White;
            chartArea3.Name = "ChartArea1";
            this.LineChart.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            legend3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            legend3.ForeColor = System.Drawing.Color.White;
            legend3.HeaderSeparatorColor = System.Drawing.Color.White;
            legend3.IsTextAutoFit = false;
            legend3.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend3.Name = "Legend1";
            legend3.TitleForeColor = System.Drawing.Color.White;
            this.LineChart.Legends.Add(legend3);
            this.LineChart.Location = new System.Drawing.Point(20, 435);
            this.LineChart.Margin = new System.Windows.Forms.Padding(2);
            this.LineChart.Name = "LineChart";
            this.LineChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            series3.LabelBackColor = System.Drawing.Color.Gray;
            series3.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.MarkerBorderColor = System.Drawing.Color.Black;
            series3.Name = "Series1";
            this.LineChart.Series.Add(series3);
            this.LineChart.Size = new System.Drawing.Size(543, 359);
            this.LineChart.TabIndex = 33;
            this.LineChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Title1";
            this.LineChart.Titles.Add(title1);
            this.LineChart.Click += new System.EventHandler(this.LineChart_Click);
            // 
            // inventoryValueHolder
            // 
            this.inventoryValueHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryValueHolder.Location = new System.Drawing.Point(561, 44);
            this.inventoryValueHolder.Margin = new System.Windows.Forms.Padding(5);
            this.inventoryValueHolder.Name = "inventoryValueHolder";
            this.inventoryValueHolder.ReadOnly = true;
            this.inventoryValueHolder.Size = new System.Drawing.Size(135, 32);
            this.inventoryValueHolder.TabIndex = 37;
            this.inventoryValueHolder.ThemeName = "Windows11Dark";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.radLabel3.Location = new System.Drawing.Point(193, 397);
            this.radLabel3.Margin = new System.Windows.Forms.Padding(5);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(170, 31);
            this.radLabel3.TabIndex = 38;
            this.radLabel3.Text = "SALES THIS WEEK";
            this.radLabel3.ThemeName = "Windows11Dark";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.radLabel4.Location = new System.Drawing.Point(1103, 397);
            this.radLabel4.Margin = new System.Windows.Forms.Padding(6);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(391, 31);
            this.radLabel4.TabIndex = 39;
            this.radLabel4.Text = "TOP 3 PRODUCTS THIS MONTH BY UNITS";
            this.radLabel4.ThemeName = "Windows11Dark";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.radLabel5.Location = new System.Drawing.Point(591, 397);
            this.radLabel5.Margin = new System.Windows.Forms.Padding(8);
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
            this.salesValueHolder.Location = new System.Drawing.Point(907, 44);
            this.salesValueHolder.Margin = new System.Windows.Forms.Padding(5);
            this.salesValueHolder.Name = "salesValueHolder";
            this.salesValueHolder.ReadOnly = true;
            this.salesValueHolder.Size = new System.Drawing.Size(135, 32);
            this.salesValueHolder.TabIndex = 0;
            this.salesValueHolder.ThemeName = "Windows11Dark";
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(772, 54);
            this.radLabel6.Margin = new System.Windows.Forms.Padding(4);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(135, 22);
            this.radLabel6.TabIndex = 41;
            this.radLabel6.Text = "SALES THIS MONTH";
            this.radLabel6.ThemeName = "Windows11Dark";
            // 
            // radLabel7
            // 
            this.radLabel7.Location = new System.Drawing.Point(49, 555);
            this.radLabel7.Margin = new System.Windows.Forms.Padding(4);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(2, 2);
            this.radLabel7.TabIndex = 42;
            this.radLabel7.ThemeName = "Windows11Dark";
            // 
            // radLabel8
            // 
            this.radLabel8.Location = new System.Drawing.Point(433, 54);
            this.radLabel8.Margin = new System.Windows.Forms.Padding(4);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(130, 22);
            this.radLabel8.TabIndex = 43;
            this.radLabel8.Text = "INVENTORY VALUE";
            this.radLabel8.ThemeName = "Windows11Dark";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.LineChart);
            this.Controls.Add(this.radLabel8);
            this.Controls.Add(this.radLabel7);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.salesValueHolder);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.inventoryValueHolder);
            this.Controls.Add(this.LowProductsListView);
            this.Controls.Add(this.radApplicationMenu1);
            this.Controls.Add(this.PieChart);
            this.Controls.Add(this.BarChart);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(1540, 845);
            this.Load += new System.EventHandler(this.DashboardView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radApplicationMenu1)).EndInit();
            this.radApplicationMenu1.ResumeLayout(false);
            this.radApplicationMenu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowProductsListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryValueHolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesValueHolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
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
        private Telerik.WinControls.UI.RadListView LowProductsListView;
        private System.Windows.Forms.DataVisualization.Charting.Chart LineChart;
        private Telerik.WinControls.UI.RadApplicationMenu radApplicationMenu1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox inventoryValueHolder;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadTextBox salesValueHolder;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadLabel radLabel8;
    }
}
