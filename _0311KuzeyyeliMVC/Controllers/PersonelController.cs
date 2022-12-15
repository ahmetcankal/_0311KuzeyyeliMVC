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

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Personeller yeniper)
        {
            db.Personeller.Add(yeniper);
            db.SaveChanges();

            return View();
        }

        public ActionResult Liste()
        {
            
            var sonuc = db.Personeller.ToList();

            return View(sonuc);
        }

       [HttpGet]
        public ActionResult Ara()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ara(Personeller frmgelen)
        {
            var sonuc = db.Personeller.Where(x => (x.Adi.Contains(frmgelen.Adi)|| x.SoyAdi.Contains(frmgelen.SoyAdi))).ToList();
            return View("Liste",sonuc);
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