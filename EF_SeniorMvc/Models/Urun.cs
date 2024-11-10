using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF_SeniorMvc.Models
{
	public class Urun
	{
        public int Id { get; set; }
        public float Fiyat { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Stok { get; set; }

    }
}