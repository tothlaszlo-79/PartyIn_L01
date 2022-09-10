using Microsoft.AspNetCore.Mvc;
using PartyIn_L01.Models;
using System.Diagnostics;

namespace PartyIn_L01.Controllers
{
    public class HomeController : Controller
    {
        //Első opció
        //public string Index()
        //{
        //    return "Hello World";
        //}

        //Második opció
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Jó reggelt" :
                "Kellemes délutánt";
            //if(hour < 12)
            //{ ViewBag.Greeting = "Jó reggelt"; }
            //else
            //{
            //    ViewBag.Greeting = "Kellemes délutánt";
            //}
            return View("MyView");
        }

        [HttpGet]
        public ViewResult InviteForm()
        {
            return View();
        }


        [HttpPost]
        public ViewResult InviteForm(GuestResponse guestResponse)
        {
            Repository.AddResponse(guestResponse);
            return View("Thanks", guestResponse);
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses
                .Where(r => r.WillAttend == true));
        }

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}