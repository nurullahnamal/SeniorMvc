using SeniorMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeniorMvc.Veri
{
	public class OgrenciVeri
	{
		public static List<Ogrenci> Ogrenciler = new List<Ogrenci>
		{
			new Ogrenci
			{
				Id = 1,
				Ad="Yusuf",
				SoyAd="Yılmaz",
				TcKimlikNo="102003030",
				BolumAd="Mimarlik",
				GirisYil=2020

			},
			new Ogrenci
			{
				Id = 2,
				Ad="Mehmet",
				SoyAd="Kucuk",
				TcKimlikNo="15885858",
				BolumAd="Tip",
				GirisYil=2021
			}
		};
	}
}