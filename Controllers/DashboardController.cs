using Microsoft.AspNetCore.Mvc;
using System;

namespace SibaECommerceDashboard.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            Random rnd = new Random();

            // Low traffic
            int lowQueue = rnd.Next(1, 9);
            int lowProcessed = lowQueue;
            int lowInstances = 2;

            // Medium traffic
            int medQueue = rnd.Next(10, 19);
            int medProcessed = medQueue - 5;
            int medInstances = 3;

            // High traffic
            int highQueue = rnd.Next(20, 30);
            int highProcessed = highQueue - 10;
            int highInstances = 4 + rnd.Next(0, 2);

            ViewBag.Low = new { Queue = lowQueue, Processed = lowProcessed, Instances = lowInstances };
            ViewBag.Med = new { Queue = medQueue, Processed = medProcessed, Instances = medInstances };
            ViewBag.High = new { Queue = highQueue, Processed = highProcessed, Instances = highInstances };

            return View();
        }
    }
}
