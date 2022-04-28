using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class WriterController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }
        public IActionResult WriterBlog()
        {
            var values = bm.GetBlogListWithCategoryByWriter(1);
            return View(values);
        }
    }
}
