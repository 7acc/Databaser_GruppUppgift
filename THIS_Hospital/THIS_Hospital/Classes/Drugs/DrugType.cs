using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace THIS_Hospital
{

    // will be tha base class of the "drug" thingymaging
    public class DrugType
    {
        public int DrugTypeId { get; set; } //Prymary key
        public string Desecription { get; set; }

        public virtual Drug Drug { get; set; } //ForeignKey

    }
}