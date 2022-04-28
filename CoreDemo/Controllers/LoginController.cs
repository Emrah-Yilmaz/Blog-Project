using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task <IActionResult> Index(Writer p)
        {

            Context c = new Context();
            var result = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail
            && x.WriterPassword == p.WriterPassword);
            if (result != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, p.WriterMail)
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Blog");

            }
            else
            {
                ViewBag.p = "Kullanıcı adı veya parola hatalı";

                return View();
            }

        }
    }
}
