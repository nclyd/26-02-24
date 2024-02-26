using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace booking_a2
{
    public partial class Menu : Form
    {
        private static Database db;
        public static Database Db { get => db; set => db = value; }

        public Menu()
        {
            InitializeComponent();
            db = new Database();
            if (!db.connect())
            {
                MessageBox.Show("Database Connection Unsuccessful.", "Error");
            }

        }
    }
}
