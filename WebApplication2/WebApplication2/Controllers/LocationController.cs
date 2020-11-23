using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class LocationController : Controller
    {

        public async Task<ActionResult> Location(string location)
        {
            Root data = new Root();

            using (var client = new HttpClient())
            {
                var uri = new Uri("https://api.openaq.org/v1/latest?location=" + location);

                var response = await client.GetAsync(uri);

                data = JsonConvert.DeserializeObject<Root>(await response.Content.ReadAsStringAsync());

            }
            if (data != null)
            {
                if (data.results != null && data.results.Count > 0)
                {
                    ViewData["location"] = data.results;
                    return View();
                }
            }
         
                return View("error");
            
        }
    }
}