
using Microsoft.AspNetCore.Mvc;

namespace KartexSolutions.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Services() => View();
    public IActionResult Contact() => View();
}
