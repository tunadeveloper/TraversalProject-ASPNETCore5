using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.PresentationLayer.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IContactUsService _contactService;
        private readonly IContactService _contactUsService;
        public ContactController(IContactUsService contactService, IContactService contactUsService)
        {
            _contactService = contactService;
            _contactUsService = contactUsService;
        }
        public IActionResult Index()
        {
            var values = _contactUsService.GetListBL().FirstOrDefault();
            return View(values);
        }


        [HttpPost]
        public IActionResult SendMessage(ContactUs contactUs)
        {
            contactUs.MessageDate = DateTime.Now;
            _contactService.InsertBL(contactUs);
            return RedirectToAction("Index", "Contact");
        }
    }
}
