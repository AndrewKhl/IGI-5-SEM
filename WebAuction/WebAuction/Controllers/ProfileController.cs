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
		private static User currentProfile;

		public ProfileController(AuctionContext context)
		{
			db = context;
		}

		[HttpGet]
		public IActionResult ChangeProfile(int id = 0)
		{
			currentProfile = id == 0 ? db.Users.FirstOrDefault(u => u.Nickname == User.Identity.Name) : db.Users.FirstOrDefault(u => u.Id == id);
			CountScore();
			ChangeProfile model = new ChangeProfile
			{
				Name = currentProfile.Name,
				Nickname = currentProfile.Nickname,
				Email = currentProfile.Email,
				Cash = currentProfile.Cash
			};

			model.SoldLots = db.Lots.Where(l => l.HostId == currentProfile.Id && l.Status != "sell").ToArray();
			model.PurchasedLots = db.Lots.Where(l => l.HostId == currentProfile.Id && l.Status == "sell").ToArray();

			return View(model);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> ChangeProfile(ChangeProfile model)
		{
			CountScore();
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

		public void CountScore()
		{
			if (currentProfile.Nickname == User.Identity.Name)
				ViewBag.Score = currentProfile.Cash;
			else
			{
				User currentUser = db.Users.FirstOrDefault(u => u.Nickname == User.Identity.Name);
				ViewBag.Score = currentUser.Cash;
			}
		}

		[HttpPost]
		public JsonResult AddCash(string sum)
		{
			var changeUser = db.Users.FirstOrDefault(u => u.Email == currentProfile.Email);
			changeUser.Cash += Convert.ToDouble(sum.Replace('.', ','));
			db.SaveChanges();
			CountScore();
			return Json(changeUser.Cash);
		}
	}
}
