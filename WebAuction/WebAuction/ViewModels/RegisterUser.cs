﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAuction.ViewModels
{
	public class RegisterUser
	{
		[Required(ErrorMessage = "Не указан Nickname")]
		public string Nickname { get; set; }

		public string Name { get; set; }

		[Required(ErrorMessage = "Не указан Email")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Не указан пароль")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[DataType(DataType.Password)]
		[Compare("Password", ErrorMessage = "Пароль введен неверно")]
		public string ConfirmPassword { get; set; }
	}
}
