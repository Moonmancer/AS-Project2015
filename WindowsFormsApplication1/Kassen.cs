using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Kasse
    {
        public bool isOpen;
        public int number;

        public Order currentOrder;

        public Kasse(int number)
        {
            this.number = number;
            this.isOpen = true;

            this.currentOrder = new Order(DateTime.Now.Ticks);
        }        
    
        public void openDesk()
        {
            this.isOpen = true;
        }

        public void closeDesk()
        {
            this.isOpen = false;
        }
    }
}
