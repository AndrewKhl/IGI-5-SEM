using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAuction.Models;

namespace WebAuction.Controllers
{
	public class HomeController : Controller
	{
		AuctionContext db;
		public HomeController(AuctionContext context)
		{
			db = context;
		}
		public IActionResult Index()
		{
			return View(db.Lots.ToList());
		}
	}
}
