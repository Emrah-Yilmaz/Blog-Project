using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
        MessageManager mn = new MessageManager(new EfMessageRepository());
        public IActionResult Index()
        {
            var values = mn.GetInboxListByWriter(1);
            return View(values);
        }
        public IActionResult MessageDetails()
        {
            var values = mn.GetMessageById(1);
            return View(values);  
        }
    }
}
