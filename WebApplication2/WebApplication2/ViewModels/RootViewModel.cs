using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.ViewModels
{
    public class RootViewModel
    {
        public Meta meta { get; set; }
        public List<Result> results { get; set; }
    }


}