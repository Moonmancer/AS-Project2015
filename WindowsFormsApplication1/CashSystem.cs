using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class CashSystem
    {
        private System.ComponentModel.IContainer components;

        string projectPath = System.IO.Directory.GetCurrentDirectory();

        private void initSiders() {
            if (this.Siders == null)
            {
                this.Siders = new List<Siders>();
            }

            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(projectPath + Config.PATH2SIDERS);

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
            if (this.Drinks == null)
            {
                this.Drinks = new List<Drinks>();
            }

            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(projectPath + Config.PATH2DRINKS);

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
            if (this.Ingridients == null)
            {
                this.Ingridients = new List<Ingredients>();
            }

            string path = projectPath + Config.PATH2INGRIENTS;

            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(projectPath + Config.PATH2INGRIENTS);

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
            if (this.Hamburger == null)
            {
                this.Hamburger = new List<Hamburger>();
            }

            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(projectPath + Config.PATH2BURGERS);

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
            if (this.Menues == null)
            {
                this.Menues = new List<Menue>();
            }

            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(projectPath + Config.PATH2MENUES);

            while ((line = file.ReadLine()) != null)
            {
                string[] product = line.Split(',');

                int id = Int32.Parse(product[0]);
                string name = product[1];
                decimal price = Decimal.Parse(product[2]);

                string[] menueEntry = product[3].Split(';');

                Drinks drink = this.Drinks.Find(d => d.id == Int32.Parse(menueEntry[0]));
                Siders sider = this.Siders.Find(s => s.id == Int32.Parse(menueEntry[1]));
                Hamburger burger = this.Hamburger.Find(b => b.id == Int32.Parse(menueEntry[2]));

                Menue menue = new Menue(id, name, price, drink, sider, burger);

                this.Menues.Add(menue);
            }
        }

        private void initCashDesks()
        {
            if (this.Kassen == null)
            {
                Kasse kasse = new Kasse(1);

                this.Kassen = new List<Kasse>();
                this.Kassen.Add(kasse);
            }
        }

        public Lager Lager
        {
            get; set;
        }

        public List<Kasse> Kassen
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
            this.initHamburger();
            this.initMenue();

            this.initCashDesks();
        }

        public List<int> getAllProducts()
        {
            throw new System.NotImplementedException();
        }
    }
}
