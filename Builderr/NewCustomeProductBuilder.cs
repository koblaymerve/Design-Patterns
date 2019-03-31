using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class NewCustomeProductBuilder : ProductBuilder
    {
        ProductViewModel ProductViewModel = new ProductViewModel();

        public override void ApplyDiscount()
        {
            ProductViewModel.Discount = ProductViewModel.UnitPrice * (decimal)0.9;
            ProductViewModel.DiscountApplied = true;
        }

        public override ProductViewModel GetModel()
        {
            return ProductViewModel;
        }

        public override void GetProductDetail(int Id)
        {
            ProductViewModel.ProductName = "Test";
            ProductViewModel.UnitPrice = 100;
            ProductViewModel.CategoryName = "Development";
        }
    }
}
