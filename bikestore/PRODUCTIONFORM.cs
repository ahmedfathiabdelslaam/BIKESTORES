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
    public partial class PRODUCTIONSFORM : Form
    {
        public PRODUCTIONSFORM()
        {
            InitializeComponent();
        }

        private void BRANDSBUTTON_Click(object sender, EventArgs e)
        {
            new BRANDSFORM().ShowDialog(); 
        }

        private void CATEGORIESBUTTON_Click(object sender, EventArgs e)
        {
            new CATEGORIESFORM().ShowDialog();
        }

        private void PRODUCTSBUTTON_Click(object sender, EventArgs e)
        {
            new PRODUCTFORM().ShowDialog();
        }

        private void STOCKSBUTTON_Click(object sender, EventArgs e)
        {
            new STOCKSFORM().ShowDialog();
        }
    }
}
