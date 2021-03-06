﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cutecms_porto.Areas.RMS.Models.DBModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RMSEntities : DbContext
    {
        public RMSEntities()
            : base("name=RMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<RMSDegree> RMSDegrees { get; set; }
        public virtual DbSet<RMSDegreeTerm> RMSDegreeTerms { get; set; }
        public virtual DbSet<RMSProgram> RMSPrograms { get; set; }
        public virtual DbSet<RMSProgramTerm> RMSProgramTerms { get; set; }
        public virtual DbSet<RMSRank> RMSRanks { get; set; }
        public virtual DbSet<RMSRankTerm> RMSRankTerms { get; set; }
        public virtual DbSet<RMSStatus> Statuses { get; set; }
        public virtual DbSet<RMSStatusTerm> RMSStatusTerms { get; set; }
        public virtual DbSet<Submission> Submissions { get; set; }
        public virtual DbSet<VacancyDegree> VacancyDegrees { get; set; }
        public virtual DbSet<VacancyRank> VacancyRanks { get; set; }
        public virtual DbSet<JobType> JobTypes { get; set; }
        public virtual DbSet<JobTypeTerm> JobTypeTerms { get; set; }
        public virtual DbSet<Applicant> Applicants { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<GenderTerm> GenderTerms { get; set; }
        public virtual DbSet<RMSLanguage> RMSLanguages { get; set; }
        public virtual DbSet<Vacancy> Vacancies { get; set; }
        public virtual DbSet<RMSDepartment> RMSDepartments { get; set; }
        public virtual DbSet<RMSDepartmentTerm> RMSDepartmentTerms { get; set; }
    }
}
