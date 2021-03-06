﻿using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAuction.Models;
using WebAuction.ViewModels;
using WebAuction.Controllers;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;

namespace WebAuction.Controllers
{
	public class HomeController : Controller
	{
		AuctionContext db;
		static string extended;

		public HomeController(AuctionContext context)
		{
			db = context;
		}

		[Authorize]
		public IActionResult Lots(int id = 0)
		{
			CountScore();
			return View(GetTableLots());
			//return View();
		}

		[Authorize]
		public IActionResult Bids()
		{
			CountScore();
			return View();
		}

		[Authorize]
		public IActionResult Users()
		{
			CountScore();
			return View(db.Users.ToList());
		}

		public void CountScore()
		{
			User currentUser = db.Users.FirstOrDefault(u => u.Nickname == User.Identity.Name);
			ViewBag.Score = currentUser.Cash;
		}

		private JsonResult Refresh(string str)
		{
			bool status = str == "false" ? false : true;
			DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(TableLot[]));
			using (MemoryStream fs = new MemoryStream())
			{
				jsonFormatter.WriteObject(fs, GetTableLots(status));
				return Json(Encoding.Default.GetString(fs.ToArray()));
			}
		}

		private TableLot[] GetTableLots(bool status = false)
		{
			var lots = !status ? db.Lots.Where
				(l => l.Status != "sell" &&
				l.Status != "ignore" &&
				DateTime.Compare(DateTime.Now, l.DateStart) > -1 &&
				DateTime.Compare(DateTime.Now, l.DateEnd) < 1) : db.Lots;

			var extendedLots = lots.Join(db.Users,
				l => l.HostId,
				u => u.Id,
				(l, u) => new TableLot
				{
					NameLot = l.NameLot,
					RedemptionPrice = l.RedemptionPrice,
					StartPrice = l.StartPrice,
					Id = l.Id,
					HostLot = u.Nickname,
					DateEnd = l.DateEnd.ToShortDateString()
				});

			var tableLots = extendedLots.ToArray();

			for (int i = 0; i < tableLots.Count(); ++i)
			{
				var lot = tableLots[i];
				Bid maxBid = db.Bids.FirstOrDefault(b => b.LotId == lot.Id);
				if (maxBid != null)
				{
					User hostBid = db.Users.FirstOrDefault(u => u.Id == maxBid.HostId);
					lot.MaxBid = maxBid.Sum;
					lot.HostBid = hostBid.Nickname;
				}
				else
				{
					lot.MaxBid = lot.StartPrice;
					lot.HostBid = "";
				}
			}

			if (extended != null)
				tableLots = tableLots.Where(l => l.NameLot.IndexOf(extended) != -1
				|| l.HostBid.IndexOf(extended) != -1
				|| l.HostLot.IndexOf(extended) != -1
				|| l.Id.ToString().IndexOf(extended) != -1
				|| l.MaxBid.ToString().IndexOf(extended) != -1
				|| l.StartPrice.ToString().IndexOf(extended) != -1
				|| l.RedemptionPrice.ToString().IndexOf(extended) != -1
			).ToArray();

			lots = db.Lots.Where(l => l.Status == "" && DateTime.Compare(DateTime.Now, l.DateEnd) != -1);

			foreach (var lot in lots)
			{
				Bid bid = db.Bids.FirstOrDefault(b => b.LotId == lot.Id);
				if (bid != null)
				{
					User hostBid = db.Users.FirstOrDefault(u => u.Id == bid.HostId);
					LotController.BuyLot(lot.Id, bid.Sum, hostBid.Nickname);
				}
				lot.Status = "ignore";
			}

			db.SaveChangesAsync();
			return tableLots;
		}

		private TableBid[] GetTableBids(bool status = false)
		{
			User currentUser = db.Users.FirstOrDefault(u => u.Nickname == User.Identity.Name);
			var bids = !status ? db.Bids.Where(b => b.HostId == currentUser.Id) : db.Bids;

			var extendedBids = bids.Join(db.Lots,
				b => b.LotId,
				l => l.Id,
				(b, l) => new TableBid
				{
					LotName = l.NameLot,
					DateEnd = l.DateEnd.ToShortDateString(),
					DateBid = b.DateBid.ToShortDateString(),
					Sum = b.Sum,
					Id = b.Id,
					LotId = l.Id,
					HostId = b.HostId
				});

			var tableBids = extendedBids.ToArray();

			for (int i = 0; i < tableBids.Count(); ++i)
				if (!status)
					tableBids[i].HostName = currentUser.Nickname;
				else
					tableBids[i].HostName = db.Users.FirstOrDefault(u => u.Id == tableBids[i].HostId).Nickname;

			return tableBids;
		}

		[HttpGet]
		public JsonResult RefreshTableBids(string str)
		{
			bool status = str == "false" ? false : true;
			DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(TableBid[]));
			using (MemoryStream fs = new MemoryStream())
			{
				jsonFormatter.WriteObject(fs, GetTableBids(status));
				return Json(Encoding.Default.GetString(fs.ToArray()));
			}
		}

		[HttpPost]
		public IActionResult SetLanguage(string culture, string returnUrl)
		{
			Response.Cookies.Append(
				CookieRequestCultureProvider.DefaultCookieName,
				CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
				new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
			);

			return LocalRedirect(returnUrl);
		}

		[HttpPost]
		public JsonResult SearchValue(string value, string status)
		{
			extended = value == "null" ? null : value;
			return Refresh(status);
		}
	}
}