using System.Linq;
using Microsoft.AspNetCore.Authorization;
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

		[Authorize]
		public IActionResult Index()
		{
			return View(db.Lots.ToList());
		}
	}
}
