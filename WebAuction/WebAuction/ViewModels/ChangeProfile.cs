using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAuction.ViewModels
{
	public class ChangeProfile
	{
		[Required(ErrorMessage = "Не указано имя")]
		public string Nickname { get; set; }

		public string Name { get; set; }

		public string Password { get; set; }

		[Required(ErrorMessage = "Не указан Email")]
		public string Email { get; set; }
	}
}
