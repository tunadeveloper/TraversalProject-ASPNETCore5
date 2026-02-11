using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using TraversalProject.SignalRLayer.Model;

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
            await Clients.All.SendAsync("ReceiveVisitorList", _visitorService.GetVisitorChartList());
        }
    }
}
