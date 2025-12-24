using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalProject.PresentationLayer.CQRS.Commands.GuideCommands;
using TraversalProject.PresentationLayer.CQRS.Queries.GuideQueries;

namespace TraversalProject.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class GuideMediatRController : Controller
    {
        private readonly IMediator _mediator;

        public GuideMediatRController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllGuideQuery());  
            return View(values);
        }

        public async Task<IActionResult> GuideDetails(int id)
        {
            var values = await _mediator.Send(new GetGuidebyIdQuery(id));
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> GuideDetails(UpdateGuideCommand command)
        {
            await _mediator.Send(command);
            return Redirect("/Admin/GuideMediatR/Index");
        }
    }
}
