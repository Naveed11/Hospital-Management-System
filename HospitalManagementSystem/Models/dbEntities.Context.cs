﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalManagementSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NaveedEntities : DbContext
    {
        public NaveedEntities()
            : base("name=NaveedEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<HMS_BirthReport> HMS_BirthReport { get; set; }
        public DbSet<HMS_DeathReport> HMS_DeathReport { get; set; }
        public DbSet<HMS_MedicineCategory> HMS_MedicineCategory { get; set; }
        public DbSet<HMS_OperationReport> HMS_OperationReport { get; set; }
        public DbSet<HMS_PatientCaseStudy> HMS_PatientCaseStudy { get; set; }
        public DbSet<HMS_Schedule> HMS_Schedule { get; set; }
        public DbSet<HMS_Medicine> HMS_Medicine { get; set; }
        public DbSet<HMS_Department> HMS_Department { get; set; }
        public DbSet<HMS_BloodGroup> HMS_BloodGroup { get; set; }
        public DbSet<Graph> Graphs { get; set; }
        public DbSet<HMS_Patient> HMS_Patient { get; set; }
        public DbSet<HMS_Document> HMS_Document { get; set; }
        public DbSet<HMS_Doctor> HMS_Doctor { get; set; }
    }
}