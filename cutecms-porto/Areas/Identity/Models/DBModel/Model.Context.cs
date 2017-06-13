﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cutecms_porto.Areas.Identity.Models.DBModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IdentityEntities : DbContext
    {
        public IdentityEntities()
            : base("name=IdentityEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<IdentityDegree> IdentityDegrees { get; set; }
        public virtual DbSet<IdentityDegreeTerm> IdentityDegreeTerms { get; set; }
        public virtual DbSet<Occupation> Occupations { get; set; }
        public virtual DbSet<IdentityPersonalTitle> IdentityPersonalTitles { get; set; }
        public virtual DbSet<IdentityProgram> IdentityPrograms { get; set; }
        public virtual DbSet<IdentityRank> IdentityRanks { get; set; }
        public virtual DbSet<IdentityRankTerm> IdentityRankTerms { get; set; }
        public virtual DbSet<IdentityPersonalTitleTerm> IdentityPersonalTitleTerms { get; set; }
        public virtual DbSet<OccupationTerm> OccupationTerms { get; set; }
        public virtual DbSet<IdentityProgramTerm> IdentityProgramTerms { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Publication> Publications { get; set; }
        public virtual DbSet<IdentityLanguage> IdentityLanguages { get; set; }
        public virtual DbSet<EmployeeType> EmployeeTypes { get; set; }
        public virtual DbSet<EmployeeTypeTerm> EmployeeTypeTerms { get; set; }
        public virtual DbSet<EmpInDept> EmpInDepts { get; set; }
        public virtual DbSet<IdentityDepartment> IdentityDepartments { get; set; }
        public virtual DbSet<IdentityDepartmentTerm> IdentityDepartmentTerms { get; set; }
    }
}
