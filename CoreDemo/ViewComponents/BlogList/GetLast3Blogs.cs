using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.BlogList
{
    public class GetLast3Blogs : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        
        public IViewComponentResult Invoke()
        {
            var values = bm.GetLast3Blogs();
            return View(values);    
        }
    }
}
