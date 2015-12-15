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
    public partial class Auswahl : Form
    {

        private string Type;
        private Bestellung bestellForm;
        private CashSystem system
        {
            get; set;
        }

        public Auswahl(Bestellung BestellForm, CashSystem system, string Typ)
        {
            this.Type = Typ;
            this.system = system;
            this.bestellForm = BestellForm;

            InitializeComponent(system, Typ);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_click(object sender, EventArgs e)
        {
            bestellForm.add("");
            bestellForm.Visible = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
