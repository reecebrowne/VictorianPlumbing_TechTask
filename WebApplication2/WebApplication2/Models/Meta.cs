﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
       public class Meta
    {
        public string name { get; set; }
        public string license { get; set; }
        public string website { get; set; }
        public int page { get; set; }
        public int limit { get; set; }
        public int found { get; set; }
    }

}