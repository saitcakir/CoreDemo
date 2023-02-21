using BusinessLayer.Concrete;
using BusinessLayer.EntityFramework;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        Message2Manager mm=new Message2Manager(new EfMessage2Repository());    
        public IViewComponentResult Invoke()
        {
            int id = 3;           
            var values=mm.GetInboxListByWriter(id);
            return View(values);
        }
    }
}
