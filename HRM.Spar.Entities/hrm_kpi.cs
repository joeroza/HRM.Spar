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
    
    public partial class hrm_kpi
    {
        public long id { get; set; }
        public string job_title_code { get; set; }
        public string kpi_indicators { get; set; }
        public Nullable<int> min_rating { get; set; }
        public Nullable<int> max_rating { get; set; }
        public Nullable<short> default_kpi { get; set; }
        public Nullable<System.DateTime> deleted_at { get; set; }
    }
}
