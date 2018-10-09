using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAuction.ViewModels
{
	public class RegisterUser
	{
		[Required(ErrorMessage = "Nickname is required")]
		public string Nickname { get; set; }

		public string Name { get; set; }

		[Required(ErrorMessage = "Email is required")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Password is required")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[DataType(DataType.Password)]
		[Compare("Password", ErrorMessage = "Enter uncorrect password")]
		public string ConfirmPassword { get; set; }
	}
}
