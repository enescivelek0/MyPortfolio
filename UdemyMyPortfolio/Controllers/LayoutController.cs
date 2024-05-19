using Microsoft.AspNetCore.Mvc;

namespace UdemyMyPortfolio.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
