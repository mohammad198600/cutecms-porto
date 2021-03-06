//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cutecms_porto.Areas.CMS.Models.DBModel
{
    using Helpers;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web;
    using System.Web.Mvc;

    public partial class ListItem
    {
        public int Id { get; set; }
        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.ValidationResources), ErrorMessageResourceName = "PropertyValueRequired")]
        [Display(Name = "Title", ResourceType = typeof(Resources.Resources))]
        public string Title { get; set; }
        [Display(Name = "Subtitle", ResourceType = typeof(Resources.Resources))]
        public string Subtitle { get; set; }
        [AllowHtml]
        [Display(Name = "ItemContent", ResourceType = typeof(Resources.Resources))]
        public string Body { get; set; }
        [Display(Name = "FileName", ResourceType = typeof(Resources.Resources))]
        public string FileName { get; set; }
        [Display(Name = "FilePath", ResourceType = typeof(Resources.Resources))]
        public string FilePath { get; set; }
        [Display(Name = "ThumbName", ResourceType = typeof(Resources.Resources))]
        public string ThumbName { get; set; }
        [Display(Name = "ThumbPath", ResourceType = typeof(Resources.Resources))]
        public string ThumbPath { get; set; }
        [Display(Name = "UrlSlug", ResourceType = typeof(Resources.Resources))]
        public string Url { get; set; }
        [Display(Name = "Class", ResourceType = typeof(Resources.Resources))]
        public string Class { get; set; }
        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.ValidationResources), ErrorMessageResourceName = "PropertyValueRequired")]
        [Display(Name = "Ordinal", ResourceType = typeof(Resources.Resources))]
        public int Ordinal { get; set; }
        [Display(Name = "Visible", ResourceType = typeof(Resources.Resources))]
        public bool Visible { get; set; }
        [ValidateImageFile]
        [Display(Name = "FilePath", ResourceType = typeof(Resources.Resources))]
        [NotMapped]
        public HttpPostedFileBase File { get; set; }
        [ValidateImage]
        [Display(Name = "ThumbPath", ResourceType = typeof(Resources.Resources))]
        [NotMapped]
        public HttpPostedFileBase Thumb { get; set; }
        [Display(Name = "ContentList", ResourceType = typeof(Resources.Resources))]
        public int ContentListId { get; set; }

        public virtual ContentList ContentList { get; set; }
    }
}
