using Microsoft.AspNetCore.Mvc;
using MileniumLocalizationMVC.Models;
using System.Diagnostics;

namespace MileniumLocalizationMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
