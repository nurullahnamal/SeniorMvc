using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ef_Demo.Models
{
	public class Computer
	{
		public int Id { get; set; }
		public string Marka { get; set; }
		public string Model { get; set; }
		public string Aciklama { get; set; }
		public double Fiyat { get; set; }
	}
}