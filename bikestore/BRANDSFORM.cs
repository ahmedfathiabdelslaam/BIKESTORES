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
    public partial class BRANDSFORM : Form
    {
        newbikestoreEntities db = new newbikestoreEntities();
        brands _bra = null;

        public BRANDSFORM()
        {
            InitializeComponent();
        }

        private void BRANDSFORM_Load(object sender, EventArgs e)
        {
            
        }

        private void SELECTALL_BRANDS_Click(object sender, EventArgs e)
        {
            
            BRAND_FORM_DATA_GRID_VIEW.DataSource = db.brands.ToList();
            var count = this.BRAND_FORM_DATA_GRID_VIEW.Rows.Cast<DataGridViewRow>().Count();
            this.COUNT_BRAND_TEXT_BOX.Text = count.ToString();
        }

        private void ADD_BUTTON_BRAND_FORM_Click(object sender, EventArgs e)
        {
            db.brands.Add(new brands()
            {
                brand_id = Convert.ToInt32(BRAND_ID_BRANDS_TEXT_BOX.Text),
                brand_name = BRAND_NAME_BRANDS_TEXT_BOX.Text
            });
            db.SaveChanges();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(BRAND_ID_BRANDS_TEXT_BOX.Text);
            _bra = db.brands.Find(id);
            BRAND_NAME_BRANDS_TEXT_BOX.Text = _bra.brand_name;

        }

        private void UPDATE_BUTTON_BRAND_FORM_Click(object sender, EventArgs e)
        {
            _bra.brand_name = BRAND_NAME_BRANDS_TEXT_BOX.Text;
            db.SaveChanges();
        }

        private void DELETE_BUTTON_BRAND_FORM_Click(object sender, EventArgs e)
        {
            db.brands.Remove(_bra);
            db.SaveChanges();
        }
    }
}
