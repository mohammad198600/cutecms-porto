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
    public partial class ImageTag
    {
        public int Id { get; set; }
        [Display(Name = "ImageFile", ResourceType = typeof(Resources.Resources))]
        public int ImageFileId { get; set; }
        [Display(Name = "Tag", ResourceType = typeof(Resources.Resources))]
        public int TagId { get; set; }

        public virtual Tag Tag { get; set; }
        public virtual ImageFile ImageFile { get; set; }
    }
}
