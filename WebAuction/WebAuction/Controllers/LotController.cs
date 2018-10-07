using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAuction.Models;
using WebAuction.ViewModels;


namespace WebAuction.Controllers
{
	public class LotController : Controller
	{
		private AuctionContext db;
		private static Lot currentLot;
		public LotController(AuctionContext context)
		{
			db = context;
		}

		[HttpGet]
		public IActionResult AddOrChangeLot(int id)
		{
			CountScore();
			currentLot = db.Lots.FirstOrDefault(l => l.Id == id);
			ChangeLot model = new ChangeLot
			{
				NameLot = currentLot.NameLot,
				Description = currentLot.Descrition,
				Quantity = currentLot.Quantity,
				StartPrice = currentLot.StartPrice,
				RedemptionPrice = currentLot.RedemptionPrice,
				DateStart = currentLot.DateStart.ToString("dd.MM.yyyy hh:mm:ss"),
				Id = currentLot.Id
			};
			TimeSpan diff = currentLot.DateEnd - currentLot.DateStart;
			model.Hours = diff.Hours;
			model.MaxBid = GetMaxBid();

			ViewData["DateStart"] = model.DateStart;

			return View(model);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> AddOrChangeLot(ChangeLot model)
		{
			CountScore();
			if (ModelState.IsValid)
			{
				currentLot = db.Lots.FirstOrDefault(l => l.Id == model.Id);
				if (currentLot == null)
				{
					currentLot = new Lot
					{
						NameLot = model.NameLot,
						Quantity = model.Quantity,
						StartPrice = model.StartPrice,
						RedemptionPrice = model.RedemptionPrice,
						Descrition = model.Description

					};

					if (model.DateStart != null)
					{
						currentLot.DateStart = DateTime.Parse(model.DateStart);
						if (currentLot.DateStart.AddMinutes(1) < DateTime.Now)
						{
							ModelState.AddModelError("DateStart", "Дата начала не может быть меньше текущей даты");
							return View(model);
						}
					}
					else
						currentLot.DateStart = DateTime.Now;

					currentLot.DateEnd = currentLot.DateStart.AddHours(model.Hours);


					User currentUser = db.Users.FirstOrDefault(u => u.Nickname == User.Identity.Name);
					currentLot.HostId = currentUser.Id;

					db.Lots.Add(currentLot);

					await db.SaveChangesAsync();
					return RedirectToAction("Index", "Home");
				}
				else
				{
					currentLot.NameLot = model.NameLot;
					currentLot.Descrition = model.Description;
					currentLot.Quantity = model.Quantity;
					currentLot.StartPrice = model.StartPrice;
					currentLot.RedemptionPrice = model.RedemptionPrice;
					if (model.DateStart == null)
						currentLot.DateStart = DateTime.Now;
					else
						currentLot.DateStart = DateTime.Parse(model.DateStart);
					if (currentLot.DateStart.AddMinutes(1) < DateTime.Now)
					{
						ModelState.AddModelError("DateStart", "Дата начала не может быть меньше текущей даты");
						return View(model);
					}

					currentLot.DateEnd = currentLot.DateStart.AddHours(model.Hours);

					await db.SaveChangesAsync();
					return RedirectToAction("Index", "Home");
				}

			}
			return View(model);
		}


		public bool BuyLot(int id_lot, double money,string nickname)
		{
			Lot lot = db.Lots.FirstOrDefault(l => l.Id == id_lot);
			User buyer = db.Users.FirstOrDefault(u => u.Nickname == nickname);
			User seller = db.Users.FirstOrDefault(u => u.Id == lot.Id);

			double max = GetMaxBid();
			Bid bid = db.Bids.FirstOrDefault(b => b.LotId == lot.Id && max == b.Sum);

			if (bid != null)
			{
				double score = bid.HostId == buyer.Id ? buyer.Cash + bid.Sum : buyer.Cash;

				if (score < money)
					return false;

				if (bid.HostId == buyer.Id)
				{
					buyer.Cash += bid.Sum;
				}
				else
				{
					User hostBid = db.Users.FirstOrDefault(u => u.Id == bid.HostId);
					hostBid.Cash += bid.Sum;
				}

				db.Bids.Remove(bid);
			}

			buyer.Cash -= money;
			seller.Cash += money;
			lot.HostId = buyer.Id;
			lot.Status = "sell";

			db.SaveChanges();
			return true;
		}

		[HttpPost]
		public IActionResult BuyLot()
		{
			if (BuyLot(currentLot.Id, currentLot.RedemptionPrice, User.Identity.Name))
				return RedirectToAction("Index", "Home");
			else
				return AddOrChangeLot(currentLot.Id);
		}


		[HttpPost]
		public JsonResult DoBid(string sum)
		{
			double max = GetMaxBid();

			double value = Convert.ToDouble(sum.Replace('.', ','));

			User currentUser = db.Users.FirstOrDefault(u => u.Nickname == User.Identity.Name);

			if (max < value && value >= currentLot.StartPrice)
			{

				Bid bid = db.Bids.FirstOrDefault(b => b.Sum == max && b.LotId == currentLot.Id);

				double score = currentUser.Cash;

				if (bid != null)
				{
					User oldBidHost = db.Users.FirstOrDefault(u => u.Id == bid.HostId);
					oldBidHost.Cash += bid.Sum;
					if (oldBidHost.Id == currentUser.Id)
						score += bid.Sum;
				}

				if (score < value)
					return Json("{ \"Status\": \"1\", \"Message\": \"Недостаточно средств!\"}");

				Bid newBid = new Bid
				{
					Sum = value,
					DateBid = DateTime.Now,
					HostId = currentUser.Id,
					LotId = currentLot.Id
				};

				currentUser.Cash -= value;

				db.Bids.Add(newBid);
				if (bid != null)
					db.Bids.Remove(bid);

				db.SaveChanges();
				string s = "{ \"Status\": \" 0 \", \"Score\": \" " + sum + " \", \"Cash\": \" " + currentUser.Cash + " \", \"Name\": \" " + currentUser.Nickname + " \" }";
				return Json(s); 
			}
			else
				return Json("{ \"Status\": \"1\", \"Message\": \"Low bid!\"}");

		}

		public JsonResult GetBid()
		{
			return Json(GetMaxBid());
		}

		private double GetMaxBid()
		{
			var bids = db.Bids.Where(b => b.LotId == currentLot.Id);
			return bids.Count() != 0 ? bids.Max(b => b.Sum) : 0;
		}

		public void CountScore()
		{
			User currentUser = db.Users.FirstOrDefault(u => u.Nickname == User.Identity.Name);
			ViewBag.Score = currentUser.Cash;	
		}


	}
}
