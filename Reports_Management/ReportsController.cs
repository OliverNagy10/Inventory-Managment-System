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
           
        }

    }
}
