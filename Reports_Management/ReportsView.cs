using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Managment_System.Reports_Management
{
    public partial class ReportsView : UserControl
    {
        public ReportsView()
        {
            InitializeComponent();
        }

        private void ReportsView_Load(object sender, EventArgs e)
        {
            // You can initialize or load other components as needed
        }

        public void DisplayTotalSalesRevenue(double totalSalesRevenue)
        {
            // Update the SalesRevenueHolder label with the calculated total sales revenue
            SalesRevenueHolder.Text =  totalSalesRevenue.ToString("0.00");
        }

        public void DisplayTotalGrossProfit(double totalGrossProfit)
        {
            // Update the SalesRevenueHolder label with the calculated total sales revenue
            grossProfitHolder.Text = totalGrossProfit.ToString("0.00");
        }
        
        public void DisplayTotalGrossMargin(double totalGrossMargin)
        {
            grossMarginHolder.Text = totalGrossMargin.ToString("0.00" + "%");

        }

    }
}
