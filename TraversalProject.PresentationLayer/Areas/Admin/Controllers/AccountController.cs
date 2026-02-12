using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TraversalProject.BusinessLayer.Abstract.UnitOfWork;
using TraversalProject.EntityLayer.Concrete;
using TraversalProject.PresentationLayer.Areas.Admin.Models;

namespace TraversalProject.PresentationLayer.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AccountViewModel account)
        {
            var senderId = _accountService.GetByIdBL(account.SenderId);
            var receiverId = _accountService.GetByIdBL(account.ReceiverId);

            senderId.Balance -= account.Amount;
            receiverId.Balance += account.Amount;

            _accountService.MultiUpdateBL(new List<Account> { senderId, receiverId });

            return View();
        }

    }
}
