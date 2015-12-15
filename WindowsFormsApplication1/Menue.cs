using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Menue : iProducts
    {
        public Menue(int id, string name, decimal price, Drinks drink, Siders sider, Hamburger burger)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.drink = drink;
            this.sider = sider;
            this.burger = burger;
            this.type = "menu"; 
        }

        public int id
        {
            get; set;
        }

        public string name
        {
            get; set;
        }

        public Drinks drink
        {
            get; set;
        }

        public Siders sider
        {
            get; set;
        }

        public Hamburger burger
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
