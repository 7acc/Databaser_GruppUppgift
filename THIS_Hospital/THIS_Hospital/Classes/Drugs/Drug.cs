using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace THIS_Hospital
{
    public class Drug
    {
        public int DrugsId { get; set; } //Prymary Key
        public string Description { get; set; }

        public virtual ICollection<Prescription> Prescriptions { get; set; }

        public virtual ICollection<DrugType> DrugTypes
        {
            get; set;

        }
    }
}