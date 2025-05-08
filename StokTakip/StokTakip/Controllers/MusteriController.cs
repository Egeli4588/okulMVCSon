using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StokTakip.Models.StokModel;

namespace StokTakip.Controllers
{
    public class MusteriController : Controller
    {
        UrunStokBaglan bag = new UrunStokBaglan();

        // GET: Musteri
        public ActionResult Index()
        {
            var liste = bag.MUSTERILER.ToList();
            return View(liste);
        }

        [HttpPost]
        public ActionResult MusteriEkle(MUSTERILER p)
        {

            bag.MUSTERILER.Add(p);
            bag.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult MusteriEkle()
        {
            return View();
        }
    }
}