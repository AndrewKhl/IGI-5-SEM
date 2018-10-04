using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAuction.Models;
using WebAuction.ViewModels;

namespace WebAuction.Controllers
{
    public class ProfileController : Controller
    {
		private AuctionContext db;

		public ProfileController(AuctionContext context)
		{
			db = context;
		}
		[HttpGet]
		public IActionResult ChangeProfile(int id = 0)
		{
			User currentUser = id == 0 ? db.Users.FirstOrDefault(u => u.Nickname == User.Identity.Name) : db.Users.FirstOrDefault(u => u.Id == id);
			ChangeProfile model = new ChangeProfile
			{
				Name = currentUser.Name,
				Nickname = currentUser.Nickname,
				Email = currentUser.Email
			};
			return View(model);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> ChangeProfile(ChangeProfile model)
		{
			if (ModelState.IsValid)
			{
				var changeUser = db.Users.FirstOrDefault(u => u.Email == model.Email);
				if (changeUser != null)
				{
					changeUser.Name = model.Name;
					changeUser.Nickname = model.Nickname;
					changeUser.Email = model.Email;
					changeUser.Password = model.Password ?? changeUser.Password;
					await db.SaveChangesAsync();
					return RedirectToAction("Index", "Home");
				}
				else
					ModelState.AddModelError("", "Ошибка авторизации");
			}

			return View(model);
		}
	}
}