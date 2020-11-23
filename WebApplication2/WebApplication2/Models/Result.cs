using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

    public class Result 
    {
        public string location { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public double distance { get; set; }
        public List<Measurement> measurements { get; set; }
        public Coordinates coordinates { get; set; }

    }
}