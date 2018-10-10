using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAuction.Models;
using WebAuction.Controllers;

namespace WebAuction
{
	public static class SampleData
	{
		public static void Initialize(AuctionContext context)
		{
			if (!context.Users.Any())
			{
				string adminRoleName = "admin";
				string userRoleName = "user";

				string adminEmail = "admin@mail.ru";
				string adminPassword = AccountController.HashPassword("123456");

				Role adminRole = new Role { Name = adminRoleName };
				Role userRole = new Role { Name = userRoleName };

				context.Roles.Add(userRole);
				context.Roles.Add(adminRole);

				context.Users.Add(new User { Email = adminEmail, Password = adminPassword, Role = adminRole, Nickname="Admin" });

				context.SaveChanges();
			}
		}
	}
}