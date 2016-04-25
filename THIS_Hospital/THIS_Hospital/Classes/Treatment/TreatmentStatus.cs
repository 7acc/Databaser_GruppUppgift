using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace THIS_Hospital
{
    public class TreatmentStatus
    {
        //------------------------------------------------
        public int TreatmentStatusID { get; set; }

        //------------------------------------------------
        [StringLength(15, ErrorMessage = "The status cant be longer than 15 characters!!")]
        public string Status { get; set; }
    }
}