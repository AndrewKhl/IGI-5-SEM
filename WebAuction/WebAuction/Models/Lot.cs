using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;


namespace WebAuction.Models
{
	[DataContract]
	public class Lot
	{
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public string NameLot { get; set; }
		public string Descrition { get; set; }
		[DataMember]
		public int Quantity { get; set; }
		public DateTime DateStart { get; set; }
		public DateTime DateEnd { get; set; }
		[DataMember]
		public string Status { get; set; }
		[DataMember]
		public double StartPrice { get; set; }
		[DataMember]
		public double RedemptionPrice { get; set; }
		public int HostId { get; set; }
	}
}
