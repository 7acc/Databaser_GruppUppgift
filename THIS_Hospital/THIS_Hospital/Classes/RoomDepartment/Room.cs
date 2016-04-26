using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace THIS_Hospital
{
    public class Room
    {
        //------------------------------------------------  
        [Required]
        public int RoomID { get; set; }

        //------------------------------------------------  
        [Required]
        [MaxLength(3, ErrorMessage = "Cant be longer than 3 digits")]
        public int RoomNr { get; set; }

        //------------------------------------------------ 
        [Required]
        public bool Avalible { get; set; }

        //------------------------------------------------  
        [Required]
        public virtual Department department { get; set; }

    }
}