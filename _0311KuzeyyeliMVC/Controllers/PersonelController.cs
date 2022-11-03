using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0311KuzeyyeliMVC.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Ekle()
        {
            return View();
        }

        public ActionResult Liste()
        {
            NorthwindEntities db = new NorthwindEntities();
            var sonuc = db.Personeller.ToList();

            return View(sonuc);
        }
        public ActionResult Ara()
        {
            return View();
        }
        public ActionResult Sil()
        {
            return View();
        }

    }
}