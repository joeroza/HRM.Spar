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
    
    public partial class hrm_home_page
    {
        public int id { get; set; }
        public int user_role_id { get; set; }
        public string action { get; set; }
        public string enable_class { get; set; }
        public int priority { get; set; }
    
        public virtual hrm_user_role hrm_user_role { get; set; }
    }
}
