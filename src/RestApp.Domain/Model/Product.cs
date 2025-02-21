﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApp.Domain.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public int ProductGroupId { get; set; }
        public int ProductSubGroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public bool IsActive { get; set; }
        public int DeliveryPointId { get; set; }

    }
}
