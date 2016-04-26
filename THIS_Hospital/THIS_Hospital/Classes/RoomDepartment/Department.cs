using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace THIS_Hospital
{
    public class Department
    {
        //------------------------------------------------  
        public int DepartentID { get; set; }

        //------------------------------------------------  

        [StringLength(20)]
        public string DepartmentName { get; set; }

        
    }
}