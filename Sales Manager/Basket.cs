using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Sales_Manager
{ 
        public class Basket
        {
            public List<Product> Items { get; set; }

            public double CalculateTotalPrice()
            {
                double total = 0;

                foreach (var item in Items)
                {
                    total += (double)item.Price * item.Quantity;
                }

                return total;
            }
        }
    }

