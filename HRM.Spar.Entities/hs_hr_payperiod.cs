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
    
    public partial class hs_hr_payperiod
    {
        public hs_hr_payperiod()
        {
            this.hs_hr_emp_basicsalary = new HashSet<hs_hr_emp_basicsalary>();
        }
    
        public string payperiod_code { get; set; }
        public string payperiod_name { get; set; }
    
        public virtual ICollection<hs_hr_emp_basicsalary> hs_hr_emp_basicsalary { get; set; }
    }
}
