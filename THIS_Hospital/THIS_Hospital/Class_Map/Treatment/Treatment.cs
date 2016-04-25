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

        public Treatment()
        {
            this.Staffs = new HashSet<Staff>();
        }

        //------------------------------------------------  
        public int TreatmentID { get; set; }

        //------------------------------------------------  
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        //------------------------------------------------     
        public bool StillAlive { get; set; }

        //------------------------------------------------  
        public int PatientID { get; set; }
        public virtual Patient Patient { get; set;}

        //------------------------------------------------
        public int WhatsDoneID { get; set; }
        public virtual WhatsDone whatsDone { get; set; }

        //------------------------------------------------
        public int TreatmentStatusID { get; set; }     
        public virtual TreatmentStatus TreatmentStatus { get; set; }

        //-----------------------------------------------
        public virtual ICollection<Staff> Staffs { get; set; }

    }
}