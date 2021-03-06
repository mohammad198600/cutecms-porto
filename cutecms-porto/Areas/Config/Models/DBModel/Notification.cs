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
    public partial class Notification
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Notification()
        {
            this.NotificationTerms = new HashSet<NotificationTerm>();
        }

        public int Id { get; set; }
        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.ValidationResources), ErrorMessageResourceName = "PropertyValueRequired")]
        [Display(Name = "Code", ResourceType = typeof(Resources.Resources))]
        public int CodeId { get; set; }
        [Display(Name = "SMTP", ResourceType = typeof(Resources.Resources))]
        public Nullable<int> SMTPId { get; set; }

        public virtual NotificationCode NotificationCode { get; set; }
        public virtual SMTPSetting SMTPSetting { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationTerm> NotificationTerms { get; set; }
    }
}
