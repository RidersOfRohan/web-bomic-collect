//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WB_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CJIT_Intervention
    {
        public int CJITInterventionID { get; set; }
        public int CJITID { get; set; }
        public Nullable<System.DateTime> InterventionDate { get; set; }
        public string PeerSupport { get; set; }
        public string MutualAid { get; set; }
        public string FamilySupport { get; set; }
        public string ParentingSupport { get; set; }
        public string HousingSupport { get; set; }
        public string EmploymentSupport { get; set; }
        public string EduTrainSupport { get; set; }
        public string SupportedWorkProj { get; set; }
        public string RecoveryCheckup { get; set; }
        public string RelapsePrevention { get; set; }
        public string ComplementaryTherapy { get; set; }
        public string MentalHealth { get; set; }
        public string OtherRecSupport { get; set; }
        public string CreatedUser { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string AmendedUser { get; set; }
        public Nullable<System.DateTime> AmendedDate { get; set; }
        public bool RecordDeleted { get; set; }
    }
}