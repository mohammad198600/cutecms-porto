//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class Submission
    {
        [Display(Name = "SubmissionId", ResourceType = typeof(Resources.Resources))]
        public int Id { get; set; }
        [Display(Name = "Vacancy", ResourceType = typeof(Resources.Resources))]
        public int VacancyId { get; set; }
        [Display(Name = "Applicant", ResourceType = typeof(Resources.Resources))]
        public int ApplicantId { get; set; }
        [Display(Name = "CoverLetter", ResourceType = typeof(Resources.Resources))]
        public string CoverLetter { get; set; }
        [Display(Name = "SubmittedOn", ResourceType = typeof(Resources.Resources))]
        public System.DateTime SubmissionDate { get; set; }

        public virtual Applicant Applicant { get; set; }
        public virtual Vacancy Vacancy { get; set; }
    }
}
