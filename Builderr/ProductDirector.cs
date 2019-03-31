﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class ProductDirector
    { 

        public void GenerateProduct(ProductBuilder productBuilder)
        {
            productBuilder.GetProductDetail(5);
            productBuilder.ApplyDiscount();

        }
    }
}
