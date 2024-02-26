using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking_a2.dbAccess
{
    class CustomerDBAccess
    {
        private Database db;

        public CustomerDBAccess(Database _db)
        {
            db = _db;
        }

        public void getAllCustomers()
        {
            string sqlCmd = "SELECT * FROM Customer order by Surname asc";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Rdr = db.Cmd.ExecuteReader();
        }
    }
}
