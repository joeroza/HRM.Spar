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
    
    public partial class hrm_project_admin
    {
        public int project_id { get; set; }
        public int emp_number { get; set; }
    
        public virtual hs_hr_employee hs_hr_employee { get; set; }
    }
}
