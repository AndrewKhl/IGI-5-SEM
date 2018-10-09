using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAuction.ViewModels
{
	public class ChangeLot
	{
		[Required(ErrorMessage = "NameRequired")]
		public string NameLot { get; set; }

		public string Description { get; set; }

		[Required(ErrorMessage = "QuantityRequired")]
		[Range(1, 1000000000, ErrorMessage = "More0")]
		public int Quantity { get; set; }
		
		[Required(ErrorMessage = "HoursRequred")]
		[Range(1, 1000000000, ErrorMessage = "More0")]
		public int Hours { get; set; }

		public string DateStart { get; set; }

		[Required(ErrorMessage = "StartRequired")]
		[Range(0.01, 1000000000, ErrorMessage = "More0")]
		public double StartPrice { get; set; }

		[Range(0.01, 1000000000, ErrorMessage = "More0")]
		public double RedemptionPrice { get; set; }

		public string Picture { get; set; }
		public int Id { get; set; }

		public double MaxBid { get; set; }
		public string HostBid { get; set; }
		public string Status { get; set; }
		public string NameHost { get; set; }
	}
}