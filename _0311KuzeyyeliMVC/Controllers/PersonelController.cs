using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0311KuzeyyeliMVC.Controllers
{
    public class PersonelController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();

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
            
            var sonuc = db.Personeller.ToList();

            return View(sonuc);
        }
        public ActionResult Ara()
        {
            return View();
        }
        public ActionResult Sil(int id)
        {
            var silinecek = db.Personeller.FirstOrDefault(x => x.PersonelID == id);

            db.Personeller.Remove(silinecek);
            db.SaveChanges();

            return RedirectToAction("Liste");
            
        }

    }
}