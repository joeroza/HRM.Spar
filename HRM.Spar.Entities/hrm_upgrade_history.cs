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
    
    public partial class hrm_upgrade_history
    {
        public int id { get; set; }
        public string start_version { get; set; }
        public string end_version { get; set; }
        public int start_increment { get; set; }
        public int end_increment { get; set; }
        public Nullable<System.DateTime> upgraded_date { get; set; }
    }
}