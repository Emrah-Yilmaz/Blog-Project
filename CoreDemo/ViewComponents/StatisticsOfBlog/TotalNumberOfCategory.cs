using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.StatisticsOfBlog
{
    public class TotalNumberOfCategory : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = bm.GetBlogListWithCategory().Count;
            ViewBag.TotalNumberOfCategory = values;
            return View();
        }
    }
}
