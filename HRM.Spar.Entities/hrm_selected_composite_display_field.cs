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
    
    public partial class hrm_selected_composite_display_field
    {
        public long id { get; set; }
        public long composite_display_field_id { get; set; }
        public long report_id { get; set; }
    
        public virtual hrm_composite_display_field hrm_composite_display_field { get; set; }
        public virtual hrm_report hrm_report { get; set; }
    }
}
