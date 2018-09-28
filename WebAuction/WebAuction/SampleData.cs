using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAuction.Models;

namespace WebAuction
{
	public static class SampleData
	{
		public static void Initialize(AuctionContext context)
		{
			if (!context.Lots.Any())
			{
				context.Lots.AddRange(new Lot
					{
						NameLot = "Cat Palina",
						RedemptionPrice = 2,
						StartPrice = 1,
						Quantity = 1,
						DateStart = new DateTime(2000, 10, 5),
						DateEnd = new DateTime(2000, 10, 5),
						HostId = 1
					}
					,
					new Lot
					{
						NameLot = "Andresha",
						RedemptionPrice = 2000,
						StartPrice = 500,
						Quantity = 1,
						DateStart = new DateTime(2000, 10, 5),
						DateEnd = new DateTime(2000, 10, 5),
						HostId = 1
					},
					new Lot
					{
						NameLot = "Pirashochek Masha",
						RedemptionPrice = 1000000000,
						StartPrice = 50000000,
						Quantity = 1,
						DateStart = new DateTime(2000, 10, 5),
						DateEnd = new DateTime(2000, 10, 5),
						HostId = 1
					}
				);
				context.SaveChanges();
			}
		}
	}
}