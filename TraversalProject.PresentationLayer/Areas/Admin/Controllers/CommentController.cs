using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;

namespace TraversalProject.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var values = _commentService.GetListCommentWithDestinationBL();
            return View(values);
        }

        public IActionResult DeleteComment(int id)
        {
            var values = _commentService.GetByIdBL(id);
            _commentService.DeleteBL(values);
            return RedirectToAction("Index", "Comment", new { area = "Admin" });
        }

        public IActionResult CommentDetail(int id)
        {
            var values = _commentService.GetListByDestinationIdBL(id);
            return View(values);
        }
    }
}
