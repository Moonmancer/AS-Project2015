using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Order
    {
        private long number {
            get; set;
        }

        private List<iProducts> products
        {
            get; set;
        }

        private List<Ingredients> extras
        {
            get; set;
        }

        public void addProduct(iProducts product , Ingredients extra)
        {
            products.Add(product);
            extras.Add(extra);
            // foreach(products) if type = product products.add; else if type = extras extras.add extras
        }

        public void getPrice()
        {
            throw new System.NotImplementedException();
            //foreach products int summe = summe + prodcuts.price;
        }

        public Order(long number)
        {
            this.number = number;
            this.products = new List<iProducts>();
            this.extras = new List<Ingredients>();
        }
    }
}
