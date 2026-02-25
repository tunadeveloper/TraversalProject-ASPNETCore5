using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using System.Threading.Tasks;
using SignalRAPIForSQL.Models;

namespace TraversalProject.SignalRAPIForSQL.Hubs
{
    public class VisitorHub : Hub
    {
        private readonly VisitorService _visitorService;
        public VisitorHub(VisitorService visitorService)
        {
            _visitorService = visitorService;
        }
        public async Task GetVisitorList()
        {
            try
            {
                var list = _visitorService.GetVisitorChartList();
                await Clients.Caller.SendAsync("ReceiveVisitorList", list ?? new List<VisitorChart>());
            }
            catch
            {
                await Clients.Caller.SendAsync("ReceiveVisitorList", new List<VisitorChart>());
            }
        }
    }
}
