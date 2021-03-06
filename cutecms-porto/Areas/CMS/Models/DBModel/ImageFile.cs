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
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class ImageFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ImageFile()
        {
            this.ImageTags = new HashSet<ImageTag>();
            this.ImageFileTerms = new HashSet<ImageFileTerm>();
        }

        public int Id { get; set; }
        public string TenantId { get; set; }
        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.ValidationResources), ErrorMessageResourceName = "PropertyValueRequired")]
        [Display(Name = "Code", ResourceType = typeof(Resources.Resources))]
        public string Code { get; set; }
        [Display(Name = "FilePath", ResourceType = typeof(Resources.Resources))]
        public string FilePath { get; set; }
        [Display(Name = "ThumbPath", ResourceType = typeof(Resources.Resources))]
        public string ThumbPath { get; set; }
        [Display(Name = "CreatedOn", ResourceType = typeof(Resources.Resources))]
        public System.DateTime CreatedOn { get; set; }
        [Display(Name = "MIME", ResourceType = typeof(Resources.Resources))]
        public string MIME { get; set; }
        [Display(Name = "Ordinal", ResourceType = typeof(Resources.Resources))]
        public Nullable<int> Ordinal { get; set; }
        [Display(Name = "Gallery", ResourceType = typeof(Resources.Resources))]
        public Nullable<int> GalleryId { get; set; }

        public virtual Gallery Gallery { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImageTag> ImageTags { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImageFileTerm> ImageFileTerms { get; set; }
    }
}
