using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAuction.Models
{
	public class Bid
	{
		public int Id { get; set; }
		public DateTime Date_bid { get; set; }
		public double Sum { get; set; }
		public int Host_id { get; set; }
		public int Lot_id { get; set; }
	}
}

