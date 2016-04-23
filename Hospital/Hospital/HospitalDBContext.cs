using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Hospital
{
    public class HospitalDBContext : DbContext
    {
        public DbSet<Staff> _Staff { get; set; }
        public DbSet<Patient> _Patient { get; set; }

        public HospitalDBContext() : base("name =HospotalDBContextConectionString")
        {

        }
    }
}