using Microsoft.AspNetCore.Mvc;
using UdemyMyPortfolio.DAL.Context;

namespace MyPortolioUdemy.ViewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {

            ViewBag.aboutTitle = context.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription= context.Abouts.Select(x=>x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail= context.Abouts.Select(x=>x.Detail).FirstOrDefault();
            return View();
        }
    }
}
