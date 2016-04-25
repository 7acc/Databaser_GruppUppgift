using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Class_Map.Treatment
{
    public class Treatment
    {



        //------------------------------------------------  
        public int TreatmentID { get; set; }

        //------------------------------------------------  
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        //------------------------------------------------     
        public bool StillAlive { get; set; }

        //------------------------------------------------  
        [ForeignKey("PatientRefID")]
        public int PatientRefID { get; set; }

        //------------------------------------------------

        [ForeignKey("WhatsDoneRefID")]
        public int? WhatsDoneRefID { get; set; }

        //------------------------------------------------
        [ForeignKey("TreatmentStatusRefID")]
        public int TreatmentStatusRefID { get; set; }

    }
}