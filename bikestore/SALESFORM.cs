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
    public partial class SALESFORM : Form
    {
        public SALESFORM()
        {
            InitializeComponent();
        }

        private void CUSTOMERS_Click(object sender, EventArgs e)
        {
            new CUSTOMERFORM().ShowDialog();
        }

        private void ORDERITEMSBUTTON_Click(object sender, EventArgs e)
        {
            new ORDERITEMSFORM().ShowDialog();
        }

        private void ORDERSBUTTON_Click(object sender, EventArgs e)
        {
            new ORDERFORM().ShowDialog();
        }

        private void STAFFSBUTTON_Click(object sender, EventArgs e)
        {
            new STAFFFORM().ShowDialog();
        }

        private void STORESBUTTON_Click(object sender, EventArgs e)
        {
            new STORESFORM().ShowDialog();
        }
    }
}
