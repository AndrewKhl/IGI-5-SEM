using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAuction.ViewModels
{
	public class TableBid
	{
		public int Id { get; set; }
		public string DateBid { get; set; }

		public double Sum { get; set; }
		public string HostName { get; set; }
		public int HostId { get; set; }
		public int LotId { get; set; }
		public string LotName { get; set; }
		public string DateEnd { get; set; }
	}
}
