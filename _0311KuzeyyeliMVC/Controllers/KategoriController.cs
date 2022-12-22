using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0311KuzeyyeliMVC.Controllers
{
    public class KategoriController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Kategori
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult KatListe()
        {
            var katlist = db.Kategoriler.ToList();
            return PartialView("_Header",katlist);
        }


    }
}