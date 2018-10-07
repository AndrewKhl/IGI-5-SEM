using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
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
		public IActionResult Index(int id = 0)
		{
			CountScore();
			return View(db.Lots.ToList());
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
		public JsonResult Refresh()
		{
			DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Lot[]));
			using (MemoryStream fs = new MemoryStream())
			{
				jsonFormatter.WriteObject(fs, db.Lots.ToArray());
				return Json(Encoding.Default.GetString(fs.ToArray()));
			}
		}

	}
}
