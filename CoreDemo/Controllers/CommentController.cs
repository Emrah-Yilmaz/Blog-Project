using BusinessLayer.Concrete; 
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CommentListByBlog(int id)
        {
            
            var values = cm.GetList(id);
            return PartialView(values);
        }
        public IActionResult PartialCommentAdd()
        {

            return PartialView();
        }
        [HttpPost]  
        public IActionResult PartialCommentAdd(Comment comment)
        {
            comment.CommentStatus = true;
            comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            cm.CommentAdd(comment);

            return PartialView();
        }

    }
}
