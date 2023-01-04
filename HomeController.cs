using DenklemWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DenklemWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(Denklem denklem)
        {

            var deger_a = denklem.A_Deger;
            var deger_b = denklem.B_Deger;
            var deger_c = denklem.C_Deger;
            var delta_ = (deger_b * deger_b) - 4 * (deger_a) * (deger_c);
            var message = string.Empty;
            double kök1_, kök2_, esit_kök_;
            if (delta_ == 0)
            {

                esit_kök_ = (-1) * (deger_b / (2 * deger_a));
                message = "Kökler eşittir ve denklemin kök : " + esit_kök_;

            }

            else if (delta_ < 0)
            {
                message = "Reel kök yoktur . ";

            }
            else {

                kök1_ = (((-1) * (deger_b)) + (Math.Sqrt(delta_))) / (2 * deger_a);
                kök2_ = (((-1) * (deger_b)) - (Math.Sqrt(delta_))) / (2 * deger_a);
                message = "Birinci Kök : " + kök1_ +  "  " + " İkinci Kök : " + kök2_;


            }
            ViewBag.Message = message;
            return View("denklem");
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