using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAuction.Models
{
	public class Bid
	{
		public int Id { get; set; }
		public DateTime DateBid { get; set; }
		public double Sum { get; set; }
		public int HostId { get; set; }
		public int LotId { get; set; }
	}
}

