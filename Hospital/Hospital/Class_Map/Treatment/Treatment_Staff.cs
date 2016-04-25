using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Class_Map.Treatment
{
    public class Treatment_Staff
    {

        //------------------------------------------------
        [Key, Column(Order = 0)]
        public int TreatmentID { get; set; }

        //------------------------------------------------
        [Key, Column(Order = 1)]
        public int StaffID { get; set; }

        //------------------------------------------------
        public virtual Treatment Treatment { get; set; }

        //------------------------------------------------
        public virtual Staff Staff { get; set; }
    }
}