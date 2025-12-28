using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PagedList.Core;
using System;
using System.Linq;
using System.Threading.Tasks;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.EntityLayer.Concrete;
using TraversalProject.PresentationLayer.Models;

namespace TraversalProject.PresentationLayer.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly ICommentService _commentService;
        private readonly UserManager<AppUser> _userManager;

        public DestinationController(IDestinationService destinationService, ICommentService commentService, UserManager<AppUser> userManager)
        {
            _destinationService = destinationService;
            _commentService = commentService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = _destinationService.GetListBL();
            return View(values);
        }

        public IActionResult DestinationDetails(int id, int page = 1)
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
        public async Task<IActionResult> CreateComment(Comment comment)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            comment.UserId = user.Id;
            comment.NameSurname = user.NameSurname;
            comment.Email = user.Email;
            comment.CreatedDate = DateTime.Now;

            _commentService.InsertBL(comment);

            return RedirectToAction("DestinationDetails", new { id = comment.DestinationId });
        }

    }
}
