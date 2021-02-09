using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartiesMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PartiesMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger; 

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Rspv()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Rspv(Attendes attendes)
        {
            if (ModelState.IsValid)
            {
                Repository.AddAttendes(attendes);
                return View("Thanks", attendes);
            }
            return View();
        }


        public ActionResult AttendeList()
        {
            IEnumerable<Attendes> listOfAttendes = Repository.attendesList.Where(attende => attende.WillAttend == true);
            return View(listOfAttendes);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        






    }
}
