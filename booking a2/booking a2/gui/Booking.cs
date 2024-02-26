using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace booking_a2.gui
{
    public partial class Booking : Form
    {

        private Database db;

        public Booking()
        {
            InitializeComponent();
            db = booking_a2.Menu.Db;
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            bool valid = false;
            dbAccess.CustomerDBAccess cDBAccess = new dbAccess.CustomerDBAccess(db);
            dbAccess.BookingDBAccess bDBAccess = new dbAccess.BookingDBAccess(db);
            objects.Customer customer = new objects.Customer();
            objects.Booking booking = new objects.Booking();
            customer.Forename = txtbForename.Text;
            try
            {
                customer.Surname = txtbSurname.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                valid = false;
            }

            customer.TelNo = Convert.ToInt32(txtbTelNo.Text);
            try
            {
                project.StartDate = calStart.SelectionStart;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                valid = false;
            }

            try
            {
                project.EndDate = calEnd.SelectionStart;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                valid = false;
            }


        }
    }
}
