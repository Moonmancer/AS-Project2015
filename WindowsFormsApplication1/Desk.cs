using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Desk
    {
        public int id
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Order currentOrder;

        public int employee
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Order lastOrder;

        public decimal balance
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public List<iProducts> allProducts;
    
        public void createOrder()
        {
            //delete(lastOrder);
            lastOrder = currentOrder;
            currentOrder = new Order(DateTime.Now.Ticks);
        }

        public void addProduct()
        {
            throw new System.NotImplementedException();
        }

        public void payOrder()
        {
            throw new System.NotImplementedException();
        }

        public void finishOrder()
        {
            throw new System.NotImplementedException();
        }
    }
}
