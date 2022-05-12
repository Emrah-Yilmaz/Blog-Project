using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        MessageManager mn = new MessageManager(new EfMessageRepository());
        public IViewComponentResult Invoke()
        {
            int id = 1;
            var values = mn.GetInboxListByWriter(id);
            return View(values);  
        }
    }
}
