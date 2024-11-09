using Microsoft.AspNetCore.Mvc;
using SeniorMvc.Models;
using SeniorMvc.Veri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace SeniorMvc.Controllers
{
	public class OgrenciController : Controller
	{
		// GET: Ogrenci
		public ActionResult Listele()
		{
			return View(OgrenciVeri.Ogrenciler);
		}


		public ActionResult Yeni()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Yeni(Ogrenci yeniOgrenci)
		{

			var id=	yeniOgrenci.Id = OgrenciVeri.Ogrenciler.Max(x => x.Id)+1;
			
			OgrenciVeri.Ogrenciler.Add(yeniOgrenci);

			return RedirectToAction("Listele");
		}

		


		public ActionResult Duzenle(int id)
		{
			var ogrenci= OgrenciVeri.Ogrenciler.Where(x=>x.Id==id).FirstOrDefault();
			return View(ogrenci);
		}

		[HttpPost]
		public ActionResult Duzenle(Ogrenci ogrenci)
		{
			Ogrenci ogrenciEdit = OgrenciVeri.Ogrenciler.Where(x => x.Id == ogrenci.Id).FirstOrDefault();
			ogrenciEdit.Ad = ogrenci.Ad;
			ogrenciEdit.SoyAd = ogrenci.SoyAd;
			ogrenciEdit.BolumAd = ogrenci.BolumAd;
			ogrenciEdit.TcKimlikNo = ogrenci.TcKimlikNo;
			ogrenciEdit.GirisYil=ogrenci.GirisYil;

			return RedirectToAction("Listele");
		}


		public ActionResult Sil(int id)
		{
			var ogrenci = OgrenciVeri.Ogrenciler.Where(x => x.Id == id).FirstOrDefault();
			return View(ogrenci);
		}


		[HttpPost]
		public ActionResult Sil(Ogrenci ogrenci)
		{
			Ogrenci ogrenciSil = OgrenciVeri.Ogrenciler.Where(x => x.Id == ogrenci.Id).FirstOrDefault();
			OgrenciVeri.Ogrenciler.Remove(ogrenciSil);
			return RedirectToAction("Listele");
		}
	}
}