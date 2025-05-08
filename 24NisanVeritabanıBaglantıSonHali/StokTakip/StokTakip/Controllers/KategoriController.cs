using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StokTakip.Models.StokModel;

namespace StokTakip.Controllers
{
    public class KategoriController : Controller
    {
        UrunStokBaglan bag = new UrunStokBaglan();

        // GET: Kategori
        public ActionResult Index()
        {
            var liste = bag.KATEGORI.ToList();
            return View(liste);
        }

        [HttpPost]
        public ActionResult KategoriEkle(KATEGORI p)
        {

            bag.KATEGORI.Add(p);
            bag.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }
    }
}