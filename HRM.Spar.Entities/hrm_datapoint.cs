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
    
    public partial class hrm_datapoint
    {
        public int id { get; set; }
        public string name { get; set; }
        public int datapoint_type_id { get; set; }
        public string definition { get; set; }
    
        public virtual hrm_datapoint_type hrm_datapoint_type { get; set; }
    }
}
