using AutoMapper;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.DTOLayer.DTOs.AnnouncementDTOs;
using TraversalProject.EntityLayer.Concrete;
using TraversalProject.PresentationLayer.Areas.Admin.Models;

namespace TraversalProject.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;

        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
           var values = _mapper.Map<List<AnnouncementListDTO>>(_announcementService.GetListBL());
            return View(values);
        }


        [HttpGet]
        public IActionResult CreateAnnouncement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAnnouncement(AnnouncementAddDTO announcement)
        {
            if (ModelState.IsValid)
            {
                _announcementService.InsertBL(new Announcement()
                {
                    Title = announcement.Title,
                    Content = announcement.Content,
                    CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return Redirect("/Admin/Announcement/Index");
            }
            return View(announcement);
          
        }
        public IActionResult DeleteAnnouncement(int id)
        {
            var values = _announcementService.GetByIdBL(id);
            _announcementService.DeleteBL(values);
            return Redirect("/Admin/Announcement/Index");
        }

        public IActionResult UpdateAnnouncement(int id)
        {
            var values = _mapper.Map<AnnouncementUpdateDTO>(_announcementService.GetByIdBL(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateAnnouncement(AnnouncementUpdateDTO announcement)
        {
            _announcementService.UpdateBL(new Announcement()
            {
                Title = announcement.Title,
                Content = announcement.Content,
                AnnouncementId = announcement.AnnouncementId,
                CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString())
            });
            return Redirect("/Admin/Announcement/Index");
        }
    }
}
