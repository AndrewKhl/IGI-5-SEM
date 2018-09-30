using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAuction.Models
{
	public class User
	{
		public int Id { get; set; }
		public string Nickname { get; set; }
		public string Name { get; set; }
		public string Password { get; set; }
		public double Cash { get; set; }
		public string Email { get; set; }

		public int? RoleId { get; set; }
		public Role Role { get; set; }

	}
}
