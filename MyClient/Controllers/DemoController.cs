using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoServiceReference;
using ProductServiceReference;

namespace MyClient.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        private DemoServiceClient demoServiceClient = new DemoServiceClient();
        private ProductServiceClient productServiceClient = new ProductServiceClient();

        [Route("")]        
        [Route("index")]        
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.result1 = demoServiceClient.HelloAsync().Result;
            ViewBag.result2 = demoServiceClient.HiAsync("Mike").Result;
            ViewBag.result3 = demoServiceClient.SumAsync(1, 2).Result;
            ViewBag.product = productServiceClient.FindAsync().Result;
            ViewBag.products = productServiceClient.FindAllAsync().Result;
            return View();
        }
    }
}
