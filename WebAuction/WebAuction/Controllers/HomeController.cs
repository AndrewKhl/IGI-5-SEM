using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAuction.Models;
using WebAuction.ViewModels;
using WebAuction.Controllers;

namespace WebAuction.Controllers
{
	public class HomeController : Controller
	{
		AuctionContext db;
		public HomeController(AuctionContext context)
		{
			db = context;
		}

		[Authorize]
		public IActionResult Index(int id = 0)
		{
			CountScore();
			return View(GetTableLots());
			//return View();
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

		[HttpGet]
		public JsonResult Refresh(string str)
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
				(l => l.Status != "Sell" && 
				l.Status != "Ignore" && 
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

			lots = db.Lots.Where(l => l.Status == "" && DateTime.Compare(DateTime.Now, l.DateEnd) != -1);

			foreach (var lot in lots)
			{
				Bid bid = db.Bids.FirstOrDefault(b => b.LotId == lot.Id);
				if (bid != null)
				{
					User hostBid = db.Users.FirstOrDefault(u => u.Id == bid.HostId);
					LotController.BuyLot(lot.Id, bid.Sum, hostBid.Nickname);
				}
				lot.Status = "Ignore";
			}

			db.SaveChangesAsync();
			return tableLots;
		}
	}
}