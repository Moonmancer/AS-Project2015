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
        public Auswahl(Bestellung BestellForm, string Typ)
        {
            Type = Typ;
            bestellForm = BestellForm;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_click(object sender, EventArgs e)
        {
            bestellForm.add("");
            this.Close();
        }
    }
}
