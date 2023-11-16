using PaggingMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaggingMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        PaggingMVCContext db = new PaggingMVCContext();
        public ActionResult Index(int pageid=1)
        {
            int skip = (pageid-1)*3;
            int count = db.People.Count();
            ViewBag.PageID = pageid;
            ViewBag.PageCount = count / 3;
            var list = db.People.OrderBy(p=>p.ID).Skip(skip).Take(3).ToList();
            return View(list);
        }
    }
}