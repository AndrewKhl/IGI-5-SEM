using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAuction.ViewModels
{
	public class ChangeLot
	{
		[Required(ErrorMessage = "Укажите имя")]
		public string NameLot { get; set; }

		public string Description { get; set; }

		[Required(ErrorMessage = "Укажите кол-во")]
		[Range(1, 1000000000, ErrorMessage = "Кол-во должно быть больше 0")]
		public int Quantity { get; set; }
		
		[Required(ErrorMessage = "Укажите кол-во часов на аукционе")]
		[Range(1, 1000000000, ErrorMessage = "Кол-во часов должно быть больше 0")]
		public int Hours { get; set; }

		public string DateStart { get; set; }

		[Required(ErrorMessage = "Укажите начальную цену")]
		[Range(0.01, 1000000000, ErrorMessage = "Цена должна быть больше 0")]
		public double StartPrice { get; set; }

		[Range(0.01, 1000000000, ErrorMessage = "Цена должна быть больше 0")]
		public double RedemptionPrice { get; set; }

		public string Picture { get; set; }
		public int Id { get; set; }

		public double MaxBid { get; set; }
		public string HostBid { get; set; }
		public string Status { get; set; }
		public string NameHost { get; set; }
	}
}