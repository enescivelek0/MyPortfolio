using Microsoft.AspNetCore.Mvc;
using UdemyMyPortfolio.DAL.Context;

namespace MyPortolioUdemy.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Features.ToList();
            return View(values);
        }
    }
}
