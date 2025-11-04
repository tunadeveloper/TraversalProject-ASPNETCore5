using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.EntityLayer.Concrete;
using TraversalProject.PresentationLayer.Models;

namespace TraversalProject.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CityList()
        {
            return Json(_destinationService.GetListBL());
        }

        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            destination.Status = true;
           _destinationService.InsertBL(destination);
            return Json(destination);
        }

        public IActionResult GetById(int id)
        {
            var values = _destinationService.GetByIdBL(id);
            return Json(values);
        }

        [HttpPost]
        public IActionResult DeleteCity(int id)
        {
            var value = _destinationService.GetByIdBL(id);
            _destinationService.DeleteBL(value);
            return Json(value);
        }

        [HttpPost]
        public IActionResult UpdateCity(Destination destination)
        {
            var existing = _destinationService.GetByIdBL(destination.DestinationId);
            existing.City = destination.City;
            existing.DayNight = destination.DayNight;
            existing.Price = destination.Price;
            _destinationService.UpdateBL(existing);
            return Json(destination);
        }
        #region Static City List
        /*
        public static List<CityClass> cities = new List<CityClass>
        {
            new CityClass
            {
                CityId = 1,
                CityName = "İstanbul",
                CityCountry = "Türkiye"
            },
            new CityClass
            {
                CityId = 2,
                CityName = "New York",
                CityCountry = "USA"
            },
            new CityClass
            {
                CityId = 3,
                CityName = "Berlin",
                CityCountry = "Germany"
            }
        };
        */
        #endregion 
    }
}
