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
    
    public partial class hrm_attendance_record
    {
        public long id { get; set; }
        public long employee_id { get; set; }
        public Nullable<System.DateTime> punch_in_utc_time { get; set; }
        public string punch_in_note { get; set; }
        public string punch_in_time_offset { get; set; }
        public Nullable<System.DateTime> punch_in_user_time { get; set; }
        public Nullable<System.DateTime> punch_out_utc_time { get; set; }
        public string punch_out_note { get; set; }
        public string punch_out_time_offset { get; set; }
        public Nullable<System.DateTime> punch_out_user_time { get; set; }
        public string state { get; set; }
    }
}
