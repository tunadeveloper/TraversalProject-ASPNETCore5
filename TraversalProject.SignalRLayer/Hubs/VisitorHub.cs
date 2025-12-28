using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using TraversalProject.SignalRLayer.Model;

namespace TraversalProject.SignalRLayer.Hubs
{
    public class VisitorHub:Hub
    {
        private readonly VisitorService _visitorService;

        public VisitorHub(VisitorService visitorService)
        {
            _visitorService = visitorService;
        }

        public async Task GetVisitorList()
        {
          //  var values = _visitorService.GetVisitorList();
            await Clients.Caller.SendAsync("CallVisitList", "values");
        }   
    }
}
