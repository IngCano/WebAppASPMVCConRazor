using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebAppASPMVCConRazor.Controllers
{
    public class Test : Controller
    {
        public IActionResult Index() {
            return View();
        }

        public IActionResult Welcome(string name, int numOfTimes = 1) {
            ViewData["Message"] = "Hello " + name + "!";
            ViewData["NumOfTimes"] = numOfTimes;

            return View();
        }
    }
}
