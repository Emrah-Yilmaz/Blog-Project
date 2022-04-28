using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());



        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }

        public IActionResult BlogDetails(int id)
        {
            ViewBag.id = id;
            var values = bm.GetBlogById(id);
            return View(values);
        }
        public IActionResult BlogAdd()
        {
            List<SelectListItem> categories = (from x in cm.GetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryId.ToString(),
                                               }).ToList();

                ViewBag.categories = categories;    
            return View();  
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {
            BlogValidate bv = new BlogValidate();       
            ValidationResult result = bv.Validate(p);   
            if (result.IsValid)
            {
                p.BlogStatus = true;
                p.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterId = 1;
                bm.TAdd(p);
                return RedirectToAction("WriterBlog", "Writer");
            }
            else
            {
                return View();
            }
            #region dosya upload işlemi
            //dosya upload işlemi
            //var extension = Path.GetExtension(p.BlogImage.FileName);
            //var newimagename = Guid.NewGuid() + extension;
            //var location = Path.Combine(Directory.GetCurrentDirectory(),
            //    "wwwroot/BlogImageFiles", newimagename);
            //var stream = new FileStream(location, FileMode.Create);
            //p.BlogImage.CopyTo(stream);
            //b.BlogImage = newimagename;
            #endregion

        }
        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            var values = bm.GetBeyId(id);
            List<SelectListItem> categories = (from x in cm.GetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryId.ToString(),
                                               }).ToList();

            ViewBag.categories = categories;
            return View(values);
        }
        [HttpPost]
        public IActionResult EditBlog(Blog p)
        {
            var blogvalue = bm.GetBeyId(p.BlogId);
            p.BlogStatus = true;
            p.WriterId = 1;
            p.CreateDate = DateTime.Parse(blogvalue.CreateDate.ToShortDateString());
            bm.TUpdate(p);

            return RedirectToAction("WriterBlog", "Writer");
        }
    }
}
