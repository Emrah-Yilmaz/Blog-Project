using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class WriterController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        WriterManager wm = new WriterManager(new EfWriterRepository());


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
        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            var values = wm.GetBeyId(1);
            return View(values);
        }

        [HttpPost]
        public IActionResult WriterEditProfile(Writer writer)
        {
            WriterValidate wl = new WriterValidate();
            ValidationResult  result = wl.Validate(writer);
            if (result.IsValid)
            {
                writer.WriterId = 1;
                writer.WriterStatus = true;
                writer.WriterImage = "yok";
                wm.TUpdate(writer);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }
        public IActionResult AddWriterImage()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult AddWriterImage(AddProfileImage addProfileImage)
        {
            Writer w = new Writer();
            if (addProfileImage != null)
            {
                var extension = Path.GetExtension(addProfileImage.WriterImage.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                addProfileImage.WriterImage.CopyTo(stream);
                w.WriterImage = newimagename;
            }

            w.WriterName = addProfileImage.WriterName;
            w.WriterMail = addProfileImage.WriterMail;  
            w.WriterPassword = addProfileImage.WriterPassword;
            w.WriterStatus = true;
            w.WriterAbout = w.WriterAbout;
            wm.TAdd(w);
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
