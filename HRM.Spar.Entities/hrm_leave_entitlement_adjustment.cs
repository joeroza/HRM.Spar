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
    
    public partial class hrm_leave_entitlement_adjustment
    {
        public int id { get; set; }
        public long adjustment_id { get; set; }
        public long entitlement_id { get; set; }
    
        public virtual hrm_leave_adjustment hrm_leave_adjustment { get; set; }
        public virtual hrm_leave_entitlement hrm_leave_entitlement { get; set; }
    }
}