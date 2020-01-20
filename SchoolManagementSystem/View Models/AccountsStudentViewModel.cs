using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagementSystem.View_Models
{
    public class AccountsStudentViewModel
    {
        public int Trans_ID { get; set; }
        public Nullable<int> S_ID { get; set; }
        public Nullable<short> Month { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Status { get; set; }

    }
}