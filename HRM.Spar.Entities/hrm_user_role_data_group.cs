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
    
    public partial class hrm_user_role_data_group
    {
        public int id { get; set; }
        public Nullable<int> user_role_id { get; set; }
        public Nullable<int> data_group_id { get; set; }
        public Nullable<sbyte> can_read { get; set; }
        public Nullable<sbyte> can_create { get; set; }
        public Nullable<sbyte> can_update { get; set; }
        public Nullable<sbyte> can_delete { get; set; }
        public Nullable<sbyte> self { get; set; }
    
        public virtual hrm_data_group hrm_data_group { get; set; }
        public virtual hrm_user_role hrm_user_role { get; set; }
    }
}
