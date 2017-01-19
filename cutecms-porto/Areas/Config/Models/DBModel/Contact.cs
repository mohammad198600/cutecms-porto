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
    public partial class Contact
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contact()
        {
            this.PhoneNumbers = new HashSet<PhoneNumber>();
        }

        public int Id { get; set; }
        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.ValidationResources), ErrorMessageResourceName = "PropertyValueRequired")]
        [Display(Name = "PersonalTitle", ResourceType = typeof(Resources.Resources))]
        public int PersonalTitleId { get; set; }
        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.ValidationResources), ErrorMessageResourceName = "PropertyValueRequired")]
        [Display(Name = "Name", ResourceType = typeof(Resources.Resources))]
        public string Name { get; set; }
        [Display(Name = "Position", ResourceType = typeof(Resources.Resources))]
        public string Position { get; set; }
        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.ValidationResources), ErrorMessageResourceName = "PropertyValueRequired")]
        [Display(Name = "Department", ResourceType = typeof(Resources.Resources))]
        public int DepartmentId { get; set; }
        [Display(Name = "Office", ResourceType = typeof(Resources.Resources))]
        public string Office { get; set; }
        [Display(Name = "Email", ResourceType = typeof(Resources.Resources))]
        public string Email { get; set; }
        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.ValidationResources), ErrorMessageResourceName = "PropertyValueRequired")]
        [Display(Name = "Organization", ResourceType = typeof(Resources.Resources))]
        public int OrganizationId { get; set; }

        public virtual Organization Organization { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }
        public virtual ConfigDepartment Department { get; set; }
        public virtual ConfigPersonalTitle PersonalTitle { get; set; }
    }
}
