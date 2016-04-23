using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital
{
    public class Patient : Person
    {
        public int PatientID { get; set; }

        public Patient(string FName,string LName,string Adress,string PhoneNr):base(FName,LName,Adress,PhoneNr)
        {

        }

    }
}