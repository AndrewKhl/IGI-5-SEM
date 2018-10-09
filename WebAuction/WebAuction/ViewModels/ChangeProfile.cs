using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WebAuction.Models;

namespace WebAuction.ViewModels
{
	public class ChangeProfile
	{
		[Required(ErrorMessage = "NameRequired")]
		public string Nickname { get; set; }

		public string Name { get; set; }

		public string Password { get; set; }

		[Required(ErrorMessage = "EmailRequired")]
		public string Email { get; set; }

		public double Cash { get; set; }

		public Lot[] PurchasedLots { get; set; }
		public Lot[] SoldLots { get; set; }
	}
}
