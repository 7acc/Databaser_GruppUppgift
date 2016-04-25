using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Hospital.Class_Map.Treatment
{
    public class WhatsDone
    {
        //------------------------------------------------
        public int WhatsDoneID { get; set; }

        //------------------------------------------------
        [StringLength(30, ErrorMessage = "The description cant be longer than 30 characters!!")]
        public string Description { get; set; }
    }
}