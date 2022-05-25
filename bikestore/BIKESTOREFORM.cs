using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bikestore
{
    public partial class BIKESTOREFORM : Form
    {
        public BIKESTOREFORM()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void product_Click(object sender, EventArgs e)
        {
            new PRODUCTIONSFORM().ShowDialog();
        }

        private void PRODUCTIONS_BUTTON_Click(object sender, EventArgs e)
        {
            new PRODUCTIONSFORM().ShowDialog();
        }

        private void SALES_BUTTON_Click(object sender, EventArgs e)
        {
            new SALESFORM().ShowDialog();
        }

        private void MAP_BIKESTORE_Click(object sender, EventArgs e)
        {
            new MAPFORM ().ShowDialog();
        }
    }
}
