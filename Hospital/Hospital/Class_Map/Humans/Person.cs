using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital
{
    public abstract class Person
    {
        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LName { get; set; }
        public string Adress { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNR { get; set; }
        [Display(Name = "Social Security Number")]
        [StringLength(10)]
        public string SSN { get; set; }
        [DataType(DataType.Date)]
        public DateTime CeckInHospital { get; set; }
        [Display(Name = "Full Name")]
        public string Name
        {
            get
            { return FName + " " + LName; }
        }

    }
}