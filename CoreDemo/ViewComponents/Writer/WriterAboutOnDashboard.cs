using BusinessLayer.Concrete;
using BusinessLayer.EntityFramework;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterAboutOnDashboard : ViewComponent
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        Context c=new Context();
        public IViewComponentResult Invoke()
        {
            var usermail = User.Identity.Name;
            var WriterID=c.Writers.Where(x=>x.WriterMail==usermail).Select(y=>y.WriterID).FirstOrDefault();
            var values = wm.GetWriterListById(WriterID);
            return View(values);
        }
    }
}
