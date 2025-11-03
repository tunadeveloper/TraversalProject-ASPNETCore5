using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TraversalProject.PresentationLayer.Models;

namespace TraversalProject.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class CityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CityList()
        {
            return Json(cities);
        }


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
    }
}
