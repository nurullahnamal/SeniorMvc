using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoPersonel.Models
{
	public class Personel
	{
		public int Id { get; set; }
		[Required(ErrorMessage ="Ad Alanı boş Kalamaz..")]
		public string Isim { get; set; }
		public string SoyIsim { get; set; }
		public string TcKimlikNo { get; set; }
		public int DogumYili { get; set; }
	}
}