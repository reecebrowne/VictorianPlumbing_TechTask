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
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> _Latest()
        {
            Root data = new Root();

            using (var client = new HttpClient())
            {
                var uri = new Uri("https://api.openaq.org/v1/latest");

                var response = await client.GetAsync(uri);

                data = JsonConvert.DeserializeObject<Root>(await response.Content.ReadAsStringAsync());

            }
            string message = "";
            for (int i = 0; i < data.results.Count; i++)
            {
                message = message + data.results[i].city + "\r\n";
            }
            ViewData["results"] = data.results;
            return View();
        }


    }
}