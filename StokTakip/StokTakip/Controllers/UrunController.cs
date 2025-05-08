using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StokTakip.Models.StokModel;

namespace StokTakip.Controllers
{
    public class UrunController : Controller
    {
        UrunStokBaglan bag = new UrunStokBaglan();

        // GET: Urun
        public ActionResult Index()
        {
            var liste = bag.URUNLER.ToList();
            return View(liste);
        }

        [HttpPost]
        public ActionResult UrunEkle(URUNLER p)
        {

            bag.URUNLER.Add(p);
            bag.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult UrunEkle()
        {
            return View();
        }

    }
}