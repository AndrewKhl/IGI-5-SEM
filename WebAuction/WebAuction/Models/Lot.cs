using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAuction.Models
{
	public class Lot
	{
		public int Id { get; set; }
		public string NameLot { get; set; }
		public string Descrition { get; set; }
		public int Quantity { get; set; }
		public DateTime DateStart { get; set; }
		public DateTime DateEnd { get; set; }
		public string Status { get; set; }
		public double StartPrice { get; set; }
		public double RedemptionPrice { get; set; }
		public int HostId { get; set; }
	}
}
