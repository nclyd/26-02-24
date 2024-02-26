using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking_a2.objects
{
    class Customer
    {
        private int telNo;
        private string forename;
        private string surname;
        private string address;

        public int TelNo { get => telNo; set => telNo = value; }
        public string Forename { get => forename; set => forename = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Address { get => address; set => address = value; }
    }
}
