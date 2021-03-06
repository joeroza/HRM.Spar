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
    
    public partial class hrm_job_candidate_history
    {
        public int id { get; set; }
        public int candidate_id { get; set; }
        public Nullable<int> vacancy_id { get; set; }
        public string candidate_vacancy_name { get; set; }
        public Nullable<int> interview_id { get; set; }
        public int action { get; set; }
        public Nullable<int> performed_by { get; set; }
        public System.DateTime performed_date { get; set; }
        public string note { get; set; }
        public string interviewers { get; set; }
    
        public virtual hrm_job_candidate hrm_job_candidate { get; set; }
        public virtual hrm_job_vacancy hrm_job_vacancy { get; set; }
        public virtual hrm_job_interview hrm_job_interview { get; set; }
        public virtual hs_hr_employee hs_hr_employee { get; set; }
    }
}
