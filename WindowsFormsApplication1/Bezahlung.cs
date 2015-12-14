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
    public partial class Bezahlung : Form
    {
        private Barbezahlung barbezahlForm;
        private Bestellung bestellForm;
        public Bezahlung(Bestellung BestellForm)
        {
            bestellForm = BestellForm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            barbezahlForm = new Barbezahlung(bestellForm);
            barbezahlForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bestellForm.clear();
            this.Close();
        }
    }
}
