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
    
    public partial class hrm_performance_tracker_reviewer
    {
        public int id { get; set; }
        public int performance_track_id { get; set; }
        public int reviewer_id { get; set; }
        public Nullable<System.DateTime> added_date { get; set; }
        public Nullable<int> status { get; set; }
    
        public virtual hrm_performance_track hrm_performance_track { get; set; }
        public virtual hs_hr_employee hs_hr_employee { get; set; }
    }
}
