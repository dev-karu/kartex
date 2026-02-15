
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace KartexSolutions.Web.Controllers;

public class AdminController : Controller
{
    public IActionResult Login() => View();

    [HttpPost]
    public IActionResult Login(string username, string password)
    {
        if(username=="admin" && password=="admin123")
        {
            HttpContext.Session.SetString("Admin","true");
            return RedirectToAction("Dashboard");
        }
        ViewBag.Error="Invalid login";
        return View();
    }

    public IActionResult Dashboard()
    {
        if(HttpContext.Session.GetString("Admin")==null)
            return RedirectToAction("Login");
        return View();
    }
}
