using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StokTakip.Models.StokModel;
namespace StokTakip.Controllers
{
    public class SatisController : Controller
    {
        UrunStokBaglan bag = new UrunStokBaglan();
        // GET: Satis
        public ActionResult Index()
        {
            var liste = bag.SATISLAR.ToList();
            return View(liste);
        }
        [HttpPost]
        public ActionResult SatisEkle(SATISLAR p)
        {

            bag.SATISLAR.Add(p);
            bag.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult SatisEkle()
        {
            return View();
        }
    }
}