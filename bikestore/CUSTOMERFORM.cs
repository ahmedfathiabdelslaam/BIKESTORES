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
    public partial class CUSTOMERFORM : Form
    {
        newbikestoreEntities db = new newbikestoreEntities();
        customers _cus = null;
        public CUSTOMERFORM()
        {
            InitializeComponent();
        }

        private void CUSTOMERFORM_Load(object sender, EventArgs e)
        {

        }

        private void SELECTALL_CATEGORIES_Click(object sender, EventArgs e)
        {
            CUSTOMER_FORM_DATA_GRID_VIEW.DataSource = db.customers.ToList();
        }

        private void ADD_BUTTON_CUSTOMER_FORM_Click(object sender, EventArgs e)
        {
            db.customers.Add(new customers()
            {
                customer_id = Convert.ToInt32(CUSTOMER_ID_CUSTOMER_TEXT_BOX.Text),
                first_name = FIRST_NAME_CUSTOMER_TEXT_BOX.Text,
                last_name = LAST_NAME_CUSTOMER_TEXT_BOX.Text,
                phone = PHONE_CUSTOMER_TEXT_BOX.Text,
                email = EMAIL_CUSTOMER_TEXT_BOX.Text,
                street = STREET_CUSTOMER_TEXT_BOX.Text,
                city = CITY_CUSTOMER_TEXT_BOX.Text,
                state = STATE_CUSTOMER_TEXT_BOX.Text
                
            });
            db.SaveChanges();
        }

        private void SEARCH_CUSTOMER_FORM_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32( CUSTOMER_ID_CUSTOMER_TEXT_BOX.Text);
             _cus = db.customers.Find(id);
             FIRST_NAME_CUSTOMER_TEXT_BOX.Text = _cus.first_name ;
             LAST_NAME_CUSTOMER_TEXT_BOX.Text = _cus.last_name ;
             PHONE_CUSTOMER_TEXT_BOX.Text = _cus.phone ;
             EMAIL_CUSTOMER_TEXT_BOX.Text = _cus.email;
             STREET_CUSTOMER_TEXT_BOX.Text = _cus.street;
            CITY_CUSTOMER_TEXT_BOX.Text = _cus.city;
            STATE_CUSTOMER_TEXT_BOX.Text = _cus.state;

        }

        private void UPDATE_BUTTON_CUSTOMER_FORM_Click(object sender, EventArgs e)
        {
            _cus.first_name = FIRST_NAME_CUSTOMER_TEXT_BOX.Text;
            _cus.last_name = LAST_NAME_CUSTOMER_TEXT_BOX.Text;
            _cus.phone = PHONE_CUSTOMER_TEXT_BOX.Text;
            _cus.email = EMAIL_CUSTOMER_TEXT_BOX.Text;
            _cus.street = STREET_CUSTOMER_TEXT_BOX.Text;
            _cus.city = CITY_CUSTOMER_TEXT_BOX.Text;
            _cus.state = STATE_CUSTOMER_TEXT_BOX.Text;
            db.SaveChanges();
        }

        private void DELETE_BUTTON_CUSTOMER_FORM_Click(object sender, EventArgs e)
        {
            db.customers.Remove(_cus);
            db.SaveChanges();
        }
       
    }
}
