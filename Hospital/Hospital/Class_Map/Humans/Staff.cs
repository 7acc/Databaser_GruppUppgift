using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hospital.Class_Map.Humans;
using Hospital.Class_Map.RoomDepartment;
using Hospital.Class_Map.Treatment;

namespace Hospital
{
    public class Staff
    {
        // ---------P-Key------------
        public int StaffID { get; set; }

        // ---------Properties--------
        [Required]
        [StringLength(50, ErrorMessage = " You cant have longer name then 50 chars!!")]
        [Display(Name = "First Name")]
        public string FName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = " You cant have longer name then 50 chars!!")]
        [Display(Name = "Last Name")]
        public string LName { get; set; }
        public string Adress { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNR { get; set; }
        [Display(Name = "Social Security Number")]
        [StringLength(10)]
        public string SSN { get; set; }       
        [DataType(DataType.Date)]
        public DateTime HierDate { get; set; }
        [Display(Name = "Full Name")]
        public string Name
        { get { return FName + " " + LName; } }

        // ----------F-Keys------------
        public Proffesion ProffesionID { get; set; }
        public Department DepartmentID { get; set; }
         virtual ICollection<Treatment> Treatments { get; set; }

        //-----------Construktor-------
        public Staff()
        {
            this.Treatments = new HashSet<Treatment>();
        }
    }
}