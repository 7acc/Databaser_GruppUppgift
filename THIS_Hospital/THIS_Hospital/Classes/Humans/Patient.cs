using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace THIS_Hospital
{
    public class Patient
    {
        // -----------P-Key------------
        public int PatientID { get; set; }

        //--------- Properties---------
        // First name
        [Required]
        [StringLength(50, ErrorMessage = " You cant have longer name then 50 chars!!")]
        [Display(Name = "First Name")]
        public string FName { get; set; }
        //Last name
        [Required]
        [StringLength(50, ErrorMessage = " You cant have longer name then 50 chars!!")]
        [Display(Name = "Last Name")]
        public string LName { get; set; }
        //Adress
        public string Adress { get; set; }
        //Phone nr
        [Display(Name = "Phone Number")]
        public string PhoneNR { get; set; }
        //Social Security Number
        [Display(Name = "Social Security Number")]
        [StringLength(10)]
        public string SSN { get; set; }
        //Time checked in to hospital
        [DataType(DataType.Date)]
        public DateTime CeckInHospital { get; set; }
        //Full name
        [Display(Name = "Full Name")]
        public string Name
        { get { return FName + " " + LName; } }

        //-----------F-Keys------------
      
        public Staff _Staff { get; set; }
        // removed  Patient._Prescription, Patient.RoomID ( just to make things work for now) Ps. realized that i could just have comented the lines out! OOOPS


        // Många till många
        public virtual ICollection<Cause> Causes { get; set; }


        // --------Construktor-----------
        public Patient()
        {
           this.Causes = new HashSet<Cause>();
        }





    }
}