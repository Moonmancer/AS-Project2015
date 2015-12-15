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
    public partial class Bestellung : Form
    {
        private Schnellauswahl additemfenster;
        private Bezahlung bezahlfenster;
        public Bestellung(CashSystem system)
        {
            InitializeComponent();
            this.system = system;
        }

        private CashSystem system {
            get; set;
        }

        private void Bestellung_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            additemfenster = new Schnellauswahl( this, system );
            additemfenster.ShowDialog();
        }

        private void button2_click(object sender, EventArgs e)
        {
            bezahlfenster = new Bezahlung( this );
            bezahlfenster.ShowDialog();
        }
        public void add(string c)
        {
            Order.Items.Add(c,true);
        }

        internal void clear()
        {
            Order.Items.Clear();
        }
    }
}
