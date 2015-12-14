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
        private Bestellung bestellForm;
        public Schnellauswahl( Bestellung BestellForm)
        {
            bestellForm = BestellForm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            additemfenster = new Auswahl(bestellForm, "Burger");
            additemfenster.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            additemfenster = new Auswahl(bestellForm, "Menu");
            additemfenster.ShowDialog();
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            additemfenster = new Auswahl(bestellForm, "Dessert");
            additemfenster.ShowDialog();
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            additemfenster = new Auswahl(bestellForm, "Siders");
            additemfenster.ShowDialog();
            this.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            additemfenster = new Auswahl(bestellForm, "Drinks");
            additemfenster.ShowDialog();
            this.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
