using Microsoft.AspNetCore.Mvc;
using MileniumLocalizationMVC.Models.AccountViewModels;

namespace MileniumLocalizationMVC.Controllers
{

    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        public AccountController()
        {
        }

        // Parameters should be removed and pass user by id and persist data
        [HttpGet]
        public IActionResult Register(string nickname = default, string email = default)
        {
            ViewData["Nickname"] = nickname;
            ViewData["Email"] = email;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel model)
        {
            // TODO check in fluent validation
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(Register), new { model.Nickname, model.Email });
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Error);
            }
            
        }
    }
}
