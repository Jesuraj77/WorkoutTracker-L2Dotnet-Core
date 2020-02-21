using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkOutTracker.Models
{
    public class WorkOutCollection
{
        public int WorkOutID { get; set; }
        public string WorkOutTitle { get; set; }
        public string Note { get; set; }
        public float CaloriesBurnPerMin { get; set; }
        public int CategoryID { get; set; }

    }
}
