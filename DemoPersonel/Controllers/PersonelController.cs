using DemoPersonel.Models;
using DemoPersonel.Veri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoPersonel.Controllers
{
	public class PersonelController : Controller
	{
		// GET: Personel
		public ActionResult Listele()
		{
			return View(PersonelVeri.personeller);
		}

		public ActionResult Ekle()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Ekle(Personel yeniPersonel)
		{
			yeniPersonel.Id = PersonelVeri.personeller.Max(x => x.Id) + 1;
			PersonelVeri.personeller.Add(yeniPersonel);
			return RedirectToAction("Listele");
		}

		
		public ActionResult Duzenle(int id)
		{
			var personel=PersonelVeri.personeller.Where(x=>x.Id==id).FirstOrDefault();
			return View(personel);
		}
		[HttpPost]
		public ActionResult Duzenle(Personel personel)
		{
			Personel personelDüzenle = PersonelVeri.personeller.Where(x =>x.Id==personel.Id).FirstOrDefault();
			personelDüzenle.Isim=personel.Isim;
			personelDüzenle.SoyIsim=personel.SoyIsim;
			personelDüzenle.TcKimlikNo=personel.TcKimlikNo;
			personelDüzenle.DogumYili=personel.DogumYili;
			return RedirectToAction("Listele");
		}



		public ActionResult Sil(int id)
		{
			var personel = PersonelVeri.personeller.Where(x => x.Id == id).FirstOrDefault();
			return View(personel);
		}

		[HttpPost]
		public ActionResult Sil(Personel personel)
		{
			Personel personelDüzenle = PersonelVeri.personeller.Where(x => x.Id == personel.Id).FirstOrDefault();
			PersonelVeri.personeller.Remove(personelDüzenle);
			return RedirectToAction("Listele");
		}



	}
}