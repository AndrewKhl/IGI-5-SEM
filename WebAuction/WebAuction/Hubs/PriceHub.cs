using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAuction.Hubs
{
	public class PriceHub : Hub
	{
		public async Task Send(string message)
		{
			await Clients.All.SendAsync("Send", message);
		}
	}
}
