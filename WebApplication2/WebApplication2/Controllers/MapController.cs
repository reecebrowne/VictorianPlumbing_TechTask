using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.ViewModels;


namespace WebApplication2.Controllers
{
    public class MapController : Controller
    {

        public async Task<ActionResult> Map()
        {
            Root data = new Root();

            using (var client = new HttpClient())
            {
                var uri = new Uri("https://api.openaq.org/v1/latest?has_geo=true");

                var response = await client.GetAsync(uri);

                data = JsonConvert.DeserializeObject<Root>(await response.Content.ReadAsStringAsync());

            }
            if (data != null)
            {
                if (data.results != null && data.results.Count > 0)
                {
                    RootViewModel results = new RootViewModel()
                    {
                        results = data.results,
                        meta = data.meta
                    };

                    return View(results);
                }
            }
         
                return View("error");
            
        }
    }
}