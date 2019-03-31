using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public bool DiscountApplied { get; set; }
    }
}
