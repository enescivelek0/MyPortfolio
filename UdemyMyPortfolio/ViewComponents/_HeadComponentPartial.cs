using Microsoft.AspNetCore.Mvc;

namespace UdemyMyPortfolio.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
