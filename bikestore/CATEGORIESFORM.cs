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
    public partial class CATEGORIESFORM : Form
    {
        newbikestoreEntities db = new newbikestoreEntities();
        categories _cat = null;
        public CATEGORIESFORM()
        {
            InitializeComponent();
        }

        private void SELECTALL_BRANDS_Click(object sender, EventArgs e)
        {
            CATEGORY_FORM_DATA_GRID_VIEW.DataSource = db.categories.ToList();
        }

        private void ADD_BUTTON_CATEGORY_FORM_Click(object sender, EventArgs e)
        {
            db.categories.Add(new categories()
            {
                category_id = Convert.ToInt32(CATEGORY_ID_CATEGORIES_TEXT_BOX.Text),
                category_name = CATEGORY_NAME_CATEGORIES_TEXT_BOX.Text
            });
            db.SaveChanges();
        }

        private void SEARCH_CATEGRIES_FORM_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(CATEGORY_ID_CATEGORIES_TEXT_BOX.Text);
             _cat = db.categories.Find(id);
            CATEGORY_NAME_CATEGORIES_TEXT_BOX.Text = _cat.category_name;
        }

        private void DELETE_BUTTON_CATEGORY_FORM_Click(object sender, EventArgs e)
        {
            db.categories.Remove(_cat);
            db.SaveChanges();
        }
    }
}
