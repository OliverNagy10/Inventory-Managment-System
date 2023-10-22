using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Sales_Manager
{
    public class SaleRecord
    {
        public DateTime Date { get; set; } // Date of the sale
        public List<Product> Items { get; set; } // List of items sold
        public double TotalSalePrice { get; set; } // Total sale price
    }
}
