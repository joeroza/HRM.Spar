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
    
    public partial class hs_hr_mailnotifications
    {
        public int user_id { get; set; }
        public int notification_type_id { get; set; }
        public int status { get; set; }
        public string email { get; set; }
    
        public virtual hrm_user hrm_user { get; set; }
    }
}
