using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;




namespace THIS_Hospital
{
    public class HospitalDBContext : DbContext
    {
        public DbSet<Staff> _Staff { get; set; }
        public DbSet<Patient> _Patient { get; set; }
        public DbSet<Treatment> _Treatment { get; set; }
        public DbSet<WhatsDone> _WhatsDone{ get; set; }
        public DbSet<TreatmentStatus> _Treatmentstatus { get; set; }
        public DbSet<Proffesion> _Proffesion { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<DrugType> DrugTypes { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }


        public HospitalDBContext() : base("name =HospitalDBContextConectionString")
        {

        }

        public System.Data.Entity.DbSet<THIS_Hospital.Cause> Causes { get; set; }

        public System.Data.Entity.DbSet<THIS_Hospital.CauseType> CauseTypes { get; set; }
    }
}