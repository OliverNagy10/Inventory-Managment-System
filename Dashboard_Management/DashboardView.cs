﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; // Make sure to include this namespace

namespace Inventory_Managment_System.Dashboard
{
    public partial class DashboardView : UserControl
    {
       

        public event EventHandler ProductManagementButtonClicked;
        public event EventHandler CheckoutButtonClicked;
        public event EventHandler BackButtonClicked;
        public event EventHandler ReportsButtonClicked;

        public DashboardView()
        {
            InitializeComponent();

            productMangementButton.Click += (sender, e) => ProductManagementButtonClicked?.Invoke(this, EventArgs.Empty);
            checkOutButton.Click += (sender, e) => CheckoutButtonClicked?.Invoke(this, EventArgs.Empty);
            backButton.Click += (sender, e) => BackButtonClicked?.Invoke(this, EventArgs.Empty);
            reportsButton.Click += (sender, e) => ReportsButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        public void UpdateInventoryValue(double value)
        {
            // Update the inventoryValueHolder label
            inventoryValueHolder.Text = "$" + value;
        }

        public void UpdateTotalSales(double sales)
        {
            // Update the totalSalesHolder label
            totalSalesHolder.Text = "$" + sales;
        }

        public void UpdateLowProductsListView(List<ListViewItem> items)
        {
            // Clear the existing items in the ListView
            LowProductsListView.Items.Clear();

            // Add the new items to the ListView
            LowProductsListView.Items.AddRange(items.ToArray());
        }

        // Add this method to update the line chart with sales data
        public void UpdateLineChartSales(Series series)
        {
            LineChart.Series.Clear();
            LineChart.Series.Add(series);

            // Set chart title and axis labels as needed
            LineChart.ChartAreas[0].AxisX.Title = "Day of the Week";
            LineChart.ChartAreas[0].AxisY.Title = "Sales";

            // Refresh the chart to display the data
            LineChart.Invalidate();
        }
        public void UpdatePieChartBestSellers(Series series)
        {
            

            PieChart.Series.Clear();
            

            PieChart.Series.Add(series);
          
            // Refresh the chart to display the data
            PieChart.Invalidate();
          
        }
        // Update the method in DashboardView
        public void UpdateBarChartBestSellers(Series series)
        {
            // Make sure to set the chart title and other properties as needed
            BarChart.Series.Clear();
            BarChart.Series.Add(series);
        }

        public void ShowLoadingMessage(bool show)
        {
            // Assuming you have a StatusLabel to display the loading message
            pictureBox1.Visible = show;
        }


        private void DashboardView_Load(object sender, EventArgs e)
        {
            // Set the View property of the basketListView to Details
            LowProductsListView.View = View.Details;
            LowProductsListView.Columns.Add("Name", 50);     // Column 1: Name
            LowProductsListView.Columns.Add("Quantity", 50); // Column 2: Quantity
        }

      
    }
}