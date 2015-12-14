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
        public Auswahl(string Typ)
        {
            Type = Typ;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
