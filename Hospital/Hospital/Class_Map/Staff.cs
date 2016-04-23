using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital
{
    public class Staff : Person
    {
        public int StaffID { get; set; }

        public Staff(string FName, string LName, string Adress, string PhoneNr):base(FName,LName,Adress,PhoneNr)
        {

        }
    }
}