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
    
    public partial class hs_hr_emp_reportto
    {
        public int erep_sup_emp_number { get; set; }
        public int erep_sub_emp_number { get; set; }
        public int erep_reporting_mode { get; set; }
    
        public virtual hrm_emp_reporting_method hrm_emp_reporting_method { get; set; }
        public virtual hs_hr_employee hs_hr_employee { get; set; }
        public virtual hs_hr_employee hs_hr_employee1 { get; set; }
    }
}
