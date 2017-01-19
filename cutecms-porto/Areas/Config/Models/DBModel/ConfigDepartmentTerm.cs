//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class ConfigDepartmentTerm
    {
        public int Id { get; set; }
        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.ValidationResources), ErrorMessageResourceName = "PropertyValueRequired")]
        [Display(Name = "Language", ResourceType = typeof(Resources.Resources))]
        public int LanguageId { get; set; }
        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.ValidationResources), ErrorMessageResourceName = "PropertyValueRequired")]
        [Display(Name = "Value", ResourceType = typeof(Resources.Resources))]
        public string Value { get; set; }
        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.ValidationResources), ErrorMessageResourceName = "PropertyValueRequired")]
        [Display(Name = "Department", ResourceType = typeof(Resources.Resources))]
        public int DepartmentId { get; set; }


        public virtual ConfigDepartment Department { get; set; }
        public virtual ConfigLanguage Language { get; set; }
    }
}
