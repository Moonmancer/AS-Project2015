﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Drinks : iProducts
    {
        public Drinks(int id, string name, decimal price) {
            this.id = id;
            this.name = name;
            this.price = price;
            this.type = "drink";
        }

        public int id
        {
            get; 
        }

        public string name
        {
            get; set;
        }

        public decimal price
        {
            get; set;
        }

        public string type
        {
            get; set;
        }
    }
}
