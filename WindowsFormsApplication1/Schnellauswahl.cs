using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Schnellauswahl : Form
    {
        private Auswahl additemfenster;
        public Schnellauswahl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            additemfenster = new Auswahl( "Burger");
            additemfenster.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            additemfenster = new Auswahl( "Menu");
            additemfenster.ShowDialog();
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            additemfenster = new Auswahl("Dessert");
            additemfenster.ShowDialog();
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            additemfenster = new Auswahl("Siders");
            additemfenster.ShowDialog();
            this.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            additemfenster = new Auswahl("Drinks");
            additemfenster.ShowDialog();
            this.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
