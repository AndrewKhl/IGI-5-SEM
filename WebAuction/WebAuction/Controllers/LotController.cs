﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAuction.Models;
using WebAuction.ViewModels;


namespace WebAuction.Controllers
{
	public class LotController : Controller
	{
		private static AuctionContext db;
		private static Lot currentLot;
		public LotController(AuctionContext context)
		{
			db = context;
		}

		[HttpGet]
		[Authorize]
		public IActionResult AddOrChangeLot(int id)
		{
			CountScore();
			currentLot = db.Lots.FirstOrDefault(l => l.Id == id);


			ChangeLot model = currentLot != null ? new ChangeLot
			{
				NameLot = currentLot.NameLot,
				Description = currentLot.Descrition,
				Quantity = currentLot.Quantity,
				StartPrice = currentLot.StartPrice,
				RedemptionPrice = currentLot.RedemptionPrice,
				DateStart = currentLot.DateStart.ToString("yyyy-MM-ddThh:mm"),
				Id = currentLot.Id,
				Status = currentLot.Status,
				Picture = currentLot.Picture

			} : new ChangeLot();

			if (currentLot != null)
			{
				TimeSpan diff = currentLot.DateEnd - currentLot.DateStart;
				model.Hours = diff.Hours;
				Bid bid = GetMaxBid();
				if (bid != null)
				{
					model.MaxBid = bid.Sum;
					model.HostBid = db.Users.FirstOrDefault(u => u.Id == bid.HostId).Nickname;
				}
				else
				{
					model.MaxBid = 0;
					model.HostBid = "";
				}

				if (model.Picture == null)
					model.Picture = "no_image.png";

				model.NameHost = db.Users.FirstOrDefault(u => u.Id == currentLot.HostId).Nickname;

				ViewBag.DateStart = currentLot.DateStart.ToString("dd.MM.yyyy hh:mm");
			}


			return View(model);
		}

		[HttpPost]
		[Authorize]
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
						Descrition = Request.Form["DescriptionLot"].ToString()

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
					currentLot.Picture = model.Picture;

					User currentUser = db.Users.FirstOrDefault(u => u.Nickname == User.Identity.Name);
					currentLot.HostId = currentUser.Id;

					db.Lots.Add(currentLot);

					await db.SaveChangesAsync();
					return RedirectToAction("Lots", "Home");
				}
				else
				{
					currentLot.NameLot = model.NameLot;
					currentLot.Descrition = Request.Form["DescriptionLot"].ToString();
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
					return RedirectToAction("Lots", "Home");
				}

			}
			return View(model);
		}


		public static bool BuyLot(int id_lot, double money, string nickname)
		{
			Lot lot = db.Lots.FirstOrDefault(l => l.Id == id_lot);
			User buyer = db.Users.FirstOrDefault(u => u.Nickname == nickname);
			User seller = db.Users.FirstOrDefault(u => u.Id == lot.Id);

			Bid bid = GetMaxBid(id_lot);

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
			lot.StartPrice = money;
			if (DateTime.Compare(DateTime.Now, lot.DateEnd) == -1)
				lot.DateEnd = DateTime.Now;

			db.SaveChanges();
			return true;
		}

		[HttpPost]
		[Authorize]
		public IActionResult BuyLot()
		{
			if (BuyLot(currentLot.Id, currentLot.RedemptionPrice, User.Identity.Name))
				return RedirectToAction("Lots", "Home");
			else
				return AddOrChangeLot(currentLot.Id);
		}


		[HttpPost]
		public JsonResult DoBid(string sum)
		{
			Bid maxBid = GetMaxBid();
			double max = maxBid != null ? maxBid.Sum : 0;

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
				string s = "{ \"Status\": \" 0\", \"Score\": \" " + sum + "\", \"Cash\": \" " + currentUser.Cash + "\", \"Name\": \" " + currentUser.Nickname + "\" }";
				return Json(s); 
			}
			else
				return Json("{ \"Status\": \"1\", \"Message\": \"Low bid!\"}");

		}

		public JsonResult GetBid()
		{
			return Json(GetMaxBid());
		}

		private static Bid GetMaxBid(int id = 0)
		{
			if (id == 0)
				id = currentLot.Id;
			var bids = db.Bids.Where(b => b.LotId == id);
			if (bids.Count() == 0)
				return null;

			Bid maxBid = bids.First();
			foreach(var bid in bids)
			{
				if (maxBid.Sum < bid.Sum)
					maxBid = bid;
			}

			return maxBid;
		}

		public void CountScore()
		{
			User currentUser = db.Users.FirstOrDefault(u => u.Nickname == User.Identity.Name);
			ViewBag.Score = currentUser.Cash;	
		}


	}
}
