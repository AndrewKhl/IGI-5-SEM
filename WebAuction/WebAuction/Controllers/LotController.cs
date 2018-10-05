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

		[HttpGet]
		public IActionResult AddOrChangeLot(int id)
		{
			Lot currentLot = db.Lots.FirstOrDefault(l => l.Id == id);
			ChangeLot model = new ChangeLot
			{
				NameLot = currentLot.NameLot,
				Description = currentLot.Descrition,
				Quantity = currentLot.Quantity,
				StartPrice = currentLot.StartPrice,
				RedemptionPrice = currentLot.RedemptionPrice,
				DateStart = currentLot.DateStart.ToString("dd.MM.yyyy hh:mm"),
				Id = currentLot.Id
			};
			TimeSpan diff = currentLot.DateEnd - currentLot.DateStart;
			model.Hours = diff.Hours;

			ViewData["DateStart"] = model.DateStart;

			return View(model);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> AddOrChangeLot(ChangeLot model)
		{
			if (ModelState.IsValid)
			{
				var lot = db.Lots.FirstOrDefault(l => l.Id == model.Id);
				if (lot == null)
				{
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
				else
				{
					lot.NameLot = model.NameLot;
					lot.Descrition = model.Description;
					lot.Quantity = model.Quantity;
					lot.StartPrice = model.StartPrice;
					lot.RedemptionPrice = model.RedemptionPrice;
					if (model.DateStart == null)
						lot.DateStart = DateTime.Now;
					else
						lot.DateStart = DateTime.Parse(model.DateStart);
					if (lot.DateStart.AddMinutes(1) < DateTime.Now)
					{
						ModelState.AddModelError("DateStart", "Дата начала не может быть меньше текущей даты");
						return View(model);
					}

					lot.DateEnd = lot.DateStart.AddHours(model.Hours);

					await db.SaveChangesAsync();
					return RedirectToAction("Index", "Home");
				}

			}
			return View(model);
		}

		public IActionResult DoBid(int id, double sum)
		{
			var bidsThisLot = db.Bids.Where(l => l.Lot_id == id);

			double max = bidsThisLot.Max(l => l.Sum);

			if (max < sum)
			{
				User currentUser = db.Users.FirstOrDefault(u => u.Name == User.Identity.Name);
				Bid newBid = new Bid
				{
					Sum = sum,
					Date_bid = DateTime.Now,
					Host_id = currentUser.Id,
					Lot_id = id
				};
				return RedirectToAction("Index", "Home");
			}
			else
			{
				ModelState.AddModelError("", "Сумма ставки слишком мала");
				return RedirectToAction("AddOrChangeLot", "Lot", id);
			}
		}
	}
}
