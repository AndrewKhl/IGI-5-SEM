using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity.UI.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WebAuction.Models;
using WebAuction.ViewModels;

namespace WebAuction.Controllers
{
	public class AccountController : Controller
	{
		private AuctionContext db;
		public AccountController(AuctionContext context)
		{
			db = context;
		}
		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Login(LoginUser model)
		{
			if (ModelState.IsValid)
			{
				string hashPassword = HashPassword(model.Password);
				User user = await db.Users.Include(u => u.Role).FirstOrDefaultAsync(u => u.Email == model.Email && u.Password == hashPassword);
				if (user != null)
				{
					
					await Authenticate(user); // аутентификация

					return RedirectToAction("Index", "Home");
				}
				ModelState.AddModelError("", "Некорректные логин и(или) пароль");
			}

			return View(model);
		}
		[HttpGet]
		public IActionResult Register()
		{
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Register(RegisterUser model)
		{
			if (ModelState.IsValid)
			{
				User user = db.Users.FirstOrDefault(u => u.Email == model.Email || u.Nickname == model.Nickname);
				if (user == null)
				{
					// добавляем пользователя в бд
					user = new User { Email = model.Email, Password = HashPassword(model.Password), Nickname=model.Nickname, Name=model.Name};
					Role userRole = await db.Roles.FirstOrDefaultAsync(r => r.Name == "user");
					if (userRole != null)
						user.Role = userRole;
					db.Users.Add(user);

					await db.SaveChangesAsync();

					await Authenticate(user); // аутентификация

					return RedirectToAction("Index", "Home");
				}
				else
					ModelState.AddModelError("", "Пользователь с таким email/nickname существует");
			}
			return View(model);
		}

		private async Task Authenticate(User user)
		{
			// создаем один claim
			var claims = new List<Claim>
			{
				new Claim(ClaimsIdentity.DefaultNameClaimType, user.Nickname),
				new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role?.Name)
			};
			// создаем объект ClaimsIdentity
			ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
			// установка аутентификационных куки
			await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
		}

		public async Task<IActionResult> Logout()
		{
			await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
			return RedirectToAction("Login", "Account");
		}

		public static string HashPassword(string password)
		{
			MD5 md5 = MD5.Create();

			byte[] data = md5.ComputeHash(Encoding.Default.GetBytes(password));

			StringBuilder hash = new StringBuilder();

			for (int i = 0; i < data.Length; i++)
				hash.Append(data[i].ToString("x2"));

			return hash.ToString();
		}
	}
}
