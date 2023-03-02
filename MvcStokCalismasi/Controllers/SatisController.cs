using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStokCalismasi.Models.Entity;

namespace MvcStokCalismasi.Controllers
{
    public class SatisController : Controller
    {
        MvcDbStokProjeEntities db = new MvcDbStokProjeEntities();
        public ActionResult Index()
        {
                return View();
        }

        [HttpGet]
        public ActionResult YeniSatis()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniSatis(TBLSATISLAR p)
        {
            db.TBLSATISLAR.Add(p);
            db.SaveChanges();
            return View("Index");
        }
    }
}