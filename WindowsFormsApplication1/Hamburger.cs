using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Hamburger : iProducts
    {
        public Hamburger(int id, string name, decimal price, List<Ingredients> ingridients)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.Ingridients = ingridients;
            this.type = "burger";
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

        public List<Ingredients> Ingridients
        {
            get; set;
        }
    }
}
