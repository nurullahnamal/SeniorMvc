using DemoPersonel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoPersonel.Veri
{
	public class PersonelVeri
	{
		public static List<Personel> personeller = new List<Personel>
		{
			new Personel
			{
				Id = 1,
				Isim="Yılmaz",
				SoyIsim="Erdoğan",
				DogumYili=1964,
				TcKimlikNo="102200202"
			},
				new Personel
			{
				Id = 2,
				Isim="Mehmet",
				SoyIsim="Yıldız",
				DogumYili=1924,
				TcKimlikNo="102200202"
			},
					new Personel
			{
				Id = 3,
				Isim="Ali",
				SoyIsim="Yılmaz",
				DogumYili=1964,
				TcKimlikNo="102200202"
			},  new Personel
			{
				Id = 4,
				Isim="Yiğit",
				SoyIsim="Türk",
				DogumYili=1964,
				TcKimlikNo="102200202"
			}
		};
	}
}