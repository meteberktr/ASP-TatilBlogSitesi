using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtelRezervasyon.Models.Sınıflar;
namespace OtelRezervasyon.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        context c = new context();
        public ActionResult Index()
        {
            var degerler = c.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}