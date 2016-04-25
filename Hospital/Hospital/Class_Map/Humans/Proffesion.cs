using Hospital.Class_Map.Cause;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital.Class_Map.Humans
{
    public class Proffesion
    {
        //---------P-Key---------------
        public int ProffesionID { get; set; }
        public string Profession_Name { get; set; }

        //----------F-Key-------------
        public virtual ICollection<CauseType> CauseTypes { get; set; }

        //--------Construktor-----------
        public Proffesion()
        {
            this.CauseTypes = new HashSet<CauseType>();
        }
    }
}