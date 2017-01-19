﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cutecms_porto.Areas.CMS.Models.DBModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class CMSEntities : DbContext
    {
        public CMSEntities()
            : base("name=CMSEntities")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<ContentType> ContentTypes { get; set; }
        public virtual DbSet<ContentTypeTerm> ContentTypeTerms { get; set; }
        public virtual DbSet<ListItem> ListItems { get; set; }
        public virtual DbSet<CMSPersonalTitle> CMSPersonalTitles { get; set; }
        public virtual DbSet<CMSPersonalTitleTerm> CMSPersonalTitleTerms { get; set; }
        public virtual DbSet<CMSStatus> CMSStatuses { get; set; }
        public virtual DbSet<CMSStatusTerm> CMSStatusTerms { get; set; }
        public virtual DbSet<TagTerm> TagTerms { get; set; }
        public virtual DbSet<GalleryTerm> GalleryTerms { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<ImageTag> ImageTags { get; set; }
        public virtual DbSet<ImageFile> ImageFiles { get; set; }
        public virtual DbSet<ImageFileTerm> ImageFileTerms { get; set; }
        public virtual DbSet<CMSDepartment> CMSDepartments { get; set; }
        public virtual DbSet<CMSDepartmentTerm> CMSDepartmentTerms { get; set; }
        public virtual DbSet<CMSLanguage> CMSLanguages { get; set; }
        public virtual DbSet<Gallery> Galleries { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<Content> Contents { get; set; }
        public virtual DbSet<ContentList> ContentLists { get; set; }
        public virtual DbSet<ContentGallery> ContentGalleries { get; set; }
    }
}
