using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital
{
    public abstract class Person
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string  Adress { get; set; }
        public string  PhoneNR { get; set; }
       public Person(string FName,string LName,string Adress,string PhoneNR)
        {

        }

    }
}