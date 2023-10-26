using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Reports_Management
{
    class ReportsController
    {
        private ReportsModel model;
        private ReportsView view;

        public ReportsController(ReportsView view, ReportsModel model)
        {
            this.view = view;
            this.model = model;
            Initialize();
        }

        private async void Initialize()
        {
            // Calculate and display the total sales revenue for the year
            double totalSalesRevenue = await model.CalculateTotalSalesThisYear();
           double totalGrossProfit= await model.CalculateTotalGrossProfitYear();
           double  totalGrossMargin = await model.CalculateTotalGrossProfitMarginYear();
            view.DisplayTotalSalesRevenue(totalSalesRevenue);
            view.DisplayTotalGrossProfit(totalGrossProfit);
            view.DisplayTotalGrossMargin(totalGrossMargin);
        }
    }
}
