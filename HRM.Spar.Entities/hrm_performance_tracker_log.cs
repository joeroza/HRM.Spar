//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRM.Spar.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class hrm_performance_tracker_log
    {
        public int id { get; set; }
        public Nullable<int> performance_track_id { get; set; }
        public string log { get; set; }
        public string comment { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<System.DateTime> added_date { get; set; }
        public Nullable<System.DateTime> modified_date { get; set; }
        public Nullable<int> reviewer_id { get; set; }
        public string achievement { get; set; }
        public Nullable<int> user_id { get; set; }
    
        public virtual hrm_performance_track hrm_performance_track { get; set; }
        public virtual hrm_user hrm_user { get; set; }
        public virtual hs_hr_employee hs_hr_employee { get; set; }
    }
}
