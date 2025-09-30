using Microsoft.AspNetCore.Mvc;
using PagedList.Core;
using System;
using System.Linq;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.EntityLayer.Concrete;
using TraversalProject.PresentationLayer.Models;

namespace TraversalProject.PresentationLayer.Controllers
{
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly ICommentService _commentService;

        public DestinationController(IDestinationService destinationService, ICommentService commentService)
        {
            _destinationService = destinationService;
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var values = _destinationService.GetListBL();
            return View(values);
        }

        public IActionResult DestinationDetails(int id = 1, int page = 1)
        {
            var destination = _destinationService.GetByIdBL(id);
            var commentsList = _commentService.GetListByDestinationIdBL(id);

            int pageSize = 4;

            var pagedComments = new PagedList<Comment>(commentsList.AsQueryable(), page, pageSize);

            var model = new CommentAndDestinationList
            {
                Destination = destination,
                Comments = pagedComments,
                PageNumber = page,
                TotalPages = pagedComments.PageCount
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult CreateComment(Comment comment)
        {
            comment.CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            _commentService.InsertBL(comment);
            return RedirectToAction("DestinationDetails", new { id = comment.DestinationId });
        }
    }
}
