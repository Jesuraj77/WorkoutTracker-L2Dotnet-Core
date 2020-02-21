using System;
using System.Collections.Generic;
using System.Text;

namespace WorkOutTracker.Models
{
    public class WorkOutActive
    {
        public int WorkOutID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime EndDate { get; set; }
        public string Comment { get; set; }
        public bool Status { get; set; }


    }
}
