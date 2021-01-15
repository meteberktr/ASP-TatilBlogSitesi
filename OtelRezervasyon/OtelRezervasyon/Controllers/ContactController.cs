using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtelRezervasyon.Models.Sınıflar;

namespace OtelRezervasyon.Controllers
{
    public class ContactController : Controller
    {
         context c = new context();
        iletisim by = new iletisim();
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult Iletisim()
        {
            return PartialView();
        }
        [HttpPost]
     public PartialViewResult Iletisim(iletisim y)
        {
            c.iletisims.Add(y);
            c.SaveChanges();
            return PartialView();
        }
        
    }
}