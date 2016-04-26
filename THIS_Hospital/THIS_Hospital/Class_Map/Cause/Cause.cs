using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital.Class_Map.Cause
{
    public class Cause
    {
        //-------P-Key------
        public int CauseID { get; set; }

        //-------Name of the cause-------
        [Required]
        [StringLength(50, ErrorMessage = " You can't have longer cause then 50 chars!!")]
        [Display(Name = "Cause")]
        public string CauseName { get; set; }

        //-------F-Key------
        public CauseType CauseTypeID { get; set; }
    }
}