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
    
    public partial class hrm_leave_entitlement
    {
        public hrm_leave_entitlement()
        {
            this.hrm_leave_entitlement_adjustment = new HashSet<hrm_leave_entitlement_adjustment>();
            this.hrm_leave_leave_entitlement = new HashSet<hrm_leave_leave_entitlement>();
        }
    
        public long id { get; set; }
        public int emp_number { get; set; }
        public decimal no_of_days { get; set; }
        public decimal days_used { get; set; }
        public long leave_type_id { get; set; }
        public System.DateTime from_date { get; set; }
        public Nullable<System.DateTime> to_date { get; set; }
        public Nullable<System.DateTime> credited_date { get; set; }
        public string note { get; set; }
        public long entitlement_type { get; set; }
        public bool deleted { get; set; }
        public Nullable<int> created_by_id { get; set; }
        public string created_by_name { get; set; }
    
        public virtual ICollection<hrm_leave_entitlement_adjustment> hrm_leave_entitlement_adjustment { get; set; }
        public virtual hrm_leave_type hrm_leave_type { get; set; }
        public virtual hs_hr_employee hs_hr_employee { get; set; }
        public virtual hrm_leave_entitlement_type hrm_leave_entitlement_type { get; set; }
        public virtual hrm_user hrm_user { get; set; }
        public virtual ICollection<hrm_leave_leave_entitlement> hrm_leave_leave_entitlement { get; set; }
    }
}
