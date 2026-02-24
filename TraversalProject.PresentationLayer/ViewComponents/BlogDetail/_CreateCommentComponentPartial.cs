using Microsoft.AspNetCore.Mvc;
using TraversalProject.PresentationLayer.Models;

namespace TraversalProject.PresentationLayer.ViewComponents.BlogDetail
{
    public class _CreateCommentComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke(CommentAndDestinationList model)
        {
            return View(model);
        }
    }
}
