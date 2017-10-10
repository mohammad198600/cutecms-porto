//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cutecms_porto.Areas.Identity.Models.DBModel
{
    using cutecms_porto.Helpers;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web;
    using System.Web.Mvc;

    public partial class IdentityDepartmentTerm
    {
        public int Id { get; set; }
        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.ValidationResources), ErrorMessageResourceName = "PropertyValueRequired")]
        [Display(Name = "Language", ResourceType = typeof(Resources.Resources))]
        public int LanguageId { get; set; }
        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.ValidationResources), ErrorMessageResourceName = "PropertyValueRequired")]
        [Display(Name = "Value", ResourceType = typeof(Resources.Resources))]
        public string Value { get; set; }
        [Display(Name = "UrlSlug", ResourceType = typeof(Resources.Resources))]
        public string UrlSlug { get; set; }
        [Display(Name = "AbsolutePath", ResourceType = typeof(Resources.Resources))]
        public string AbsolutePath { get; set; }
        [ValidateIcon]
        [Display(Name = "Icon", ResourceType = typeof(Resources.Resources))]
        public HttpPostedFileBase Icon { get; set; }
        [Display(Name = "IconName", ResourceType = typeof(Resources.Resources))]
        public string IconName { get; set; }
        [Display(Name = "IconPath", ResourceType = typeof(Resources.Resources))]
        public string IconPath { get; set; }
        [Display(Name = "Summary", ResourceType = typeof(Resources.Resources))]
        public string Summary { get; set; }
        [AllowHtml]
        [Display(Name = "Description", ResourceType = typeof(Resources.Resources))]
        public string Description { get; set; }
        [ValidateImage]
        [Display(Name = "Image", ResourceType = typeof(Resources.Resources))]
        public HttpPostedFileBase Image { get; set; }

        [Display(Name = "ImageName", ResourceType = typeof(Resources.Resources))]
        public string ImageName { get; set; }
        [Display(Name = "ImagePath", ResourceType = typeof(Resources.Resources))]
        public string ImagePath { get; set; }
        [Display(Name = "Visible", ResourceType = typeof(Resources.Resources))]
        public bool Visible { get; set; }   
        [Display(Name = "HomeVisible", ResourceType = typeof(Resources.Resources))]
        public bool HomeVisible { get; set; }
        [Display(Name = "Ordinal", ResourceType = typeof(Resources.Resources))]
        public Nullable<int> Ordinal { get; set; }
        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.ValidationResources), ErrorMessageResourceName = "PropertyValueRequired")]
        [Display(Name = "Department", ResourceType = typeof(Resources.Resources))]
        public int DepartmentId { get; set; }

        public virtual IdentityDepartment Department { get; set; }
        public virtual IdentityLanguage Language { get; set; }
    }
}
