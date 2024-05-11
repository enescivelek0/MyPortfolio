using Microsoft.AspNetCore.Mvc;

namespace UdemyMyPortfolio.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
