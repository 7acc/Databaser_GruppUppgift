using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace THIS_Hospital
{
    public class Prescription
    {
        [Required]
        public int PrescriptionId { get; set; }// Prymary key
        //public int PatientId { get; set; }

        public DateTime Date { get; set; }
        //public int StaffId { get; set; }
        [ForeignKey("Drug")]
        public virtual Drug Drug { get; set; }
        //public virtual DrugType DrugsType { get; set; }

        public virtual ICollection<Staff> Staffs { get; set; } // One to M

    }
}