using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class CashSystem
    {
        private System.ComponentModel.IContainer components;

        private void initSiders() {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(Config.PATH2SIDERS);

            while ((line = file.ReadLine()) != null)
            {
                string[] product = line.Split(',');

                int id = Int32.Parse(product[0]);
                string name = product[1];
                decimal price = Decimal.Parse(product[2]);

                Siders sider = new Siders(id, name, price);

                this.Siders.Add(sider);
            }
        }

        private void initDrinks() {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(Config.PATH2SIDERS);

            while ((line = file.ReadLine()) != null)
            {
                string[] product = line.Split(',');

                int id = Int32.Parse(product[0]);
                string name = product[1];
                decimal price = Decimal.Parse(product[2]);

                Drinks drink = new Drinks(id, name, price);

                this.Drinks.Add(drink);
            }
        }

        private void initIngridients()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(Config.PATH2INGRIENTS);

            while ((line = file.ReadLine()) != null)
            {
                string[] product = line.Split(',');

                int id = Int32.Parse(product[0]);
                string name = product[1];

                Ingredients ingridients = new Ingredients(id, name);

                this.Ingridients.Add(ingridients);
            }
        }

        private void initHamburger()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(Config.PATH2BURGERS);

            while ((line = file.ReadLine()) != null)
            {
                string[] product = line.Split(',');

                int id = Int32.Parse(product[0]);
                string name = product[1];
                decimal price = Decimal.Parse(product[2]);

                List <Ingredients> ingridients = new List <Ingredients>();

                string[] ingridientsRaw = product[3].Split(';');

                foreach (string ingridient in ingridientsRaw) {
                    ingridients.Add(this.Ingridients.Find(ing => ing.id == Int32.Parse(ingridient)));
                }

                Hamburger burger = new Hamburger(id, name, price, ingridients);

                this.Hamburger.Add(burger);
            }
        }

        private void initMenue()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(Config.PATH2MENUES);

            while ((line = file.ReadLine()) != null)
            {
                string[] product = line.Split(',');

                int id = Int32.Parse(product[0]);
                string name = product[1];
                decimal price = Decimal.Parse(product[2]);

                Drinks drink = this.Drinks.Find(d => d.id == Int32.Parse(product[3]));
                Siders sider = this.Siders.Find(s => s.id == Int32.Parse(product[4]));
                Hamburger burger = this.Hamburger.Find(b => b.id == Int32.Parse(product[5]));

                Menue menue = new Menue(id, name, price, drink, sider, burger);

                this.Menues.Add(menue);
            }
        }

        public Lager Lager
        {
            get; set;
        }

        public Kassen Kasse
        {
            get; set;
        }

        public List<Siders> Siders
        {
            get; set;
        }

        public List<Drinks> Drinks
        {
            get; set;
        }

        public List<Ingredients> Ingridients
        {
            get; set;
        }

        public List<Hamburger> Hamburger
        {
            get; set;
        }

        public List<Menue> Menues
        {
            get; set;
        }

        public void init()
        {
            this.initIngridients();
            this.initDrinks();
            this.initSiders();
            this.initMenue();
        }

        public List<int> getAllProducts()
        {
            throw new System.NotImplementedException();
        }
    }
}
