//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagementSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccountsTeacher
    {
        public int Trans_ID { get; set; }
        public Nullable<int> F_ID { get; set; }
        public Nullable<System.DateTime> Month { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Status { get; set; }
    
        public virtual Teacher Teacher { get; set; }
    }
}
