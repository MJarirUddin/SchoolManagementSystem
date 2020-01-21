using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagementSystem.View_Models
{
    public class StudentViewModel
    {
        public int S_ID { get; set; }
        public string SName { get; set; }
        public string FName { get; set; }
        public string Contact { get; set; }
        public string Class { get; set; }
        public int Fee { get; set; }
        public string GR_NO { get; set; }
    }
}