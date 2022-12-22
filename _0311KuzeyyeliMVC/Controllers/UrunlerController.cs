using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0311KuzeyyeliMVC.Controllers
{
    public class UrunlerController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Urunler
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Liste(int id)
        {
            var sonuc = db.Urunler.Where(x=>x.KategoriID==id).ToList();
            return View(sonuc);
        }


    }
}