using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {

        RegisterManager rm = new RegisterManager(new EfWriterRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer p)
        {
            WriterValidate wv = new WriterValidate();
            ValidationResult result = wv.Validate(p);   



            if (result.IsValid)
            {
                p.WriterStatus = true;
                p.WriterImage = "buraya dosya yolu eklenecek";
                p.WriterAbout = "Yazar bilgileri gelecek";
                rm.WriterAdd(p);
                return RedirectToAction("Index", "Blog");


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
    }
}
