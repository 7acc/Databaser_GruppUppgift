using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace THIS_Hospital
{
    public class CauseType
    {
        //-------P-Key-------
        public int CauseTypeID { get; set; }

        //-------Cause-Type Name-------
        [Required]
        [StringLength(50, ErrorMessage = " You can't have longer cause-type then 50 chars!!")]
        [Display(Name = "Cause Type")]
        public string CauseTypeName { get; set; }
    }
}