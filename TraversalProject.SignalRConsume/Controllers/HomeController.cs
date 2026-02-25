using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TraversalProject.SignalRConsume.Models;

namespace TraversalProject.SignalRConsume.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            var hubUrl = _configuration["SignalR:HubUrl"] ?? "http://localhost:16423/VisitorHub";
            ViewBag.SignalRHubUrl = hubUrl;
            return View();
        }

    }
}
