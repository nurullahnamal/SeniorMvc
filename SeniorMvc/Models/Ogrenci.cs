using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeniorMvc.Models
{
	public class Ogrenci
	{
		public int Id { get; set; }
		public string Ad { get; set; }
		public string SoyAd { get; set; }
		public string TcKimlikNo { get; set; }
		public string BolumAd { get; set; }
		public int GirisYil { get; set; }
	}
}