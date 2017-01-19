﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cutecms_porto.Areas.Config.Models.DBModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class ConfigEntities : DbContext
    {
        public ConfigEntities()
            : base("name=ConfigEntities")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public virtual DbSet<Statistic> Statistics { get; set; }
        public virtual DbSet<ConfigDepartment> ConfigDepartments { get; set; }
        public virtual DbSet<ConfigDepartmentTerm> ConfigDepartmentTerms { get; set; }
        public virtual DbSet<ConfigPersonalTitle> ConfigPersonalTitles { get; set; }
        public virtual DbSet<ConfigPersonalTitleTerm> ConfigPersonalTitleTerms { get; set; }
        public virtual DbSet<ConfigLanguage> ConfigLanguages { get; set; }
        public virtual DbSet<NotificationTerm> NotificationTerms { get; set; }
        public virtual DbSet<SMTPSetting> SMTPSettings { get; set; }
        public virtual DbSet<NotificationCode> NotificationCodes { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<ConfigStatus> Statuses { get; set; }
        public virtual DbSet<ConfigStatusTerm> ConfigStatusTerms { get; set; }
    }
}
