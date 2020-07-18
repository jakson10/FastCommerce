﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FastCommerce.Entities.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public DateTime LastModified { get; set; }
        public int Quantity { get; set; }
        public int Rating { get; set; }
        public double Price { get; set; }

        
    }
}