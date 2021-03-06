﻿using Microsoft.EntityFrameworkCore;

namespace WebAuction.Models
{
	public class AuctionContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Lot> Lots { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<Bid> Bids { get; set; }

		public AuctionContext(DbContextOptions<AuctionContext> options) : base(options)
		{
			Database.EnsureCreated();
		}
	}
}
