using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Measurement
    {
        public string parameter { get; set; }
        public double value { get; set; }
        public DateTime lastUpdated { get; set; }
        public string unit { get; set; }
        public string sourceName { get; set; }
        public AveragingPeriod averagingPeriod { get; set; }
    }

}