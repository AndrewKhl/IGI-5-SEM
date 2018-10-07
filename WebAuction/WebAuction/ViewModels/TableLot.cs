using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAuction.ViewModels
{
	public class TableLot
	{
		public string NameLot { get; set; }
		public string DateEnd { get; set; }
		public double RedemptionPrice { get; set; }
		public double StartPrice { get; set; }
		public int Id { get; set; }
		public double MaxBid { get; set; }
		public string HostBid { get; set; }
		public string HostLot { get; set; }
	}
}
