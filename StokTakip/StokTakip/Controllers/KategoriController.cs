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

        public ActionResult Sil(int id)
        {
            var deger = bag.KATEGORI.Find(id);
            bag.KATEGORI.Remove(deger);
            bag.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult KategoriGuncelle(int id)
        {
            var deger = bag.KATEGORI.Find(id);
            return  View("KategoriGuncelle",deger);
        }

        public ActionResult Guncelle(KATEGORI P1)
        {
            var deger = bag.KATEGORI.Find(P1.KATEGORID);
            deger.KATEGORIAD = P1.KATEGORIAD;
            bag.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}