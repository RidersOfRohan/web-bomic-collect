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
    
    public partial class inpatient
    {
        public int srno { get; set; }
        public Nullable<decimal> dexp { get; set; }
        public Nullable<decimal> trz { get; set; }
        public Nullable<System.DateTime> trx { get; set; }
        public int mno { get; set; }
        public Nullable<System.DateTime> refdate { get; set; }
        public Nullable<int> provider { get; set; }
        public Nullable<int> type { get; set; }
        public Nullable<decimal> accepted { get; set; }
        public Nullable<System.DateTime> withdrawn { get; set; }
        public Nullable<System.DateTime> admitted { get; set; }
        public Nullable<System.DateTime> discharge { get; set; }
        public string rem1 { get; set; }
        public Nullable<decimal> can { get; set; }
        public Nullable<decimal> nta { get; set; }
        public string user_new { get; set; }
        public Nullable<System.DateTime> user_new_date { get; set; }
        public string user_delete { get; set; }
        public Nullable<System.DateTime> user_delete_date { get; set; }
        public Nullable<decimal> dexp1 { get; set; }
        public string user_upd { get; set; }
        public Nullable<System.DateTime> dtalter { get; set; }
    }
}
