using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAuction.Models;
using WebAuction.ViewModels;

namespace WebAuction.Controllers
{
	public class LotController : Controller
	{
		private AuctionContext db;
		public LotController(AuctionContext context)
		{
			db = context;
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> AddOrChangeLot(ChangeLot model)
		{
			if (ModelState.IsValid)
			{
				Lot lot = db.Lots.FirstOrDefault(l => l.Id == model.Id);
				if (lot == null)
				{
					// добавляем пользователя в бд
					lot = new Lot
					{
						NameLot = model.NameLot,
						Quantity = model.Quantity,
						StartPrice = model.StartPrice,
						RedemptionPrice = model.RedemptionPrice,
						Descrition = model.Description

					};

					if (model.DateStart != null)
					{
						lot.DateStart = DateTime.Parse(model.DateStart);
						if (lot.DateStart.AddMinutes(1) < DateTime.Now)
						{
							ModelState.AddModelError("DateStart", "Дата начала не может быть меньше текущей даты");
							return View(model);
						}
					}
					else
						lot.DateStart = DateTime.Now.AddMinutes(5);

					lot.DateEnd = lot.DateStart.AddHours(model.Hours);


					User currentUser = db.Users.FirstOrDefault(u => u.Nickname == User.Identity.Name);
					lot.HostId = currentUser.Id;

					db.Lots.Add(lot);

					await db.SaveChangesAsync();

					return RedirectToAction("Index", "Home");
				}
				//else добавить на изменение

			}

			return View(model);
		}
	}
}