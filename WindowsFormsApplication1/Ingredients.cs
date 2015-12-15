using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Ingredients
    {
        public Ingredients(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int id
        {
            get; set;
        }

        public string name
        {
            get; set;
        }
    }
}
