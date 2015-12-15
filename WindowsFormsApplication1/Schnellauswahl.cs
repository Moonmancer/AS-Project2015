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

        private CashSystem system
        {
            get; set;
        }

        public Schnellauswahl( Bestellung BestellForm, CashSystem system)
        {
            this.system = system;
            this.bestellForm = BestellForm;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            additemfenster = new Auswahl(bestellForm, system, "burger");
            additemfenster.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            additemfenster = new Auswahl(bestellForm, system, "Menu");
            additemfenster.ShowDialog();
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            additemfenster = new Auswahl(bestellForm, system, "dessert");
            additemfenster.ShowDialog();
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            additemfenster = new Auswahl(bestellForm, system, "sider");
            additemfenster.ShowDialog();
            this.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            additemfenster = new Auswahl(bestellForm, system, "drink");
            additemfenster.ShowDialog();
            this.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
