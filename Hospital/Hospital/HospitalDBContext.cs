using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Hospital.Class_Map.Treatment;

namespace Hospital
{
    public class HospitalDBContext : DbContext
    {
        public DbSet<Staff> _Staff { get; set; }
        public DbSet<Patient> _Patient { get; set; }
        public DbSet<Treatment> _Treatment { get; set; }
        public DbSet<WhatsDone> _WhatsDone{ get; set; }
        public DbSet<TreatmentStatus> _Treatmentstatus { get; set; }
        public DbSet<Treatment_Staff> _Treatment_staff { get; set; }

        public HospitalDBContext() : base("name =HospitalDBContextConectionString")
        {

        }
    }
}