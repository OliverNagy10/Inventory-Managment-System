using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Supplier { get; set; }
        public double Price { get; set; }
        public int Barcode { get; set; }
        public int Quantity { get; set; }
    }
}
