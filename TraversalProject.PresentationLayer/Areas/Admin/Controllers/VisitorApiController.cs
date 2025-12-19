using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TraversalProject.PresentationLayer.Areas.Admin.Models;

namespace TraversalProject.PresentationLayer.Areas.Admin.Controllers
{
    [AllowAnonymous]

    [Area("Admin")]
    public class VisitorApiController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public VisitorApiController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:46167/api/Visitor");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<VisitorViewModel>>(jsonData);
                return View(values);

            }
            return View();
        }

        public IActionResult CreateVisitor() => View();

        [HttpPost]

        public async Task<IActionResult> CreateVisitor(VisitorViewModel visitorViewModel)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(visitorViewModel);
            StringContent stringContent = new(jsonData, System.Text.Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:46167/api/Visitor", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return Redirect("/Admin/VisitorApi/Index");
            }
            return View();
        }

        public async Task<IActionResult> DeleteVisitor(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:46167/api/Visitor/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return Redirect("/Admin/VisitorApi/Index");
            }
            return View();
        }
        public async Task<IActionResult> UpdateVisitor(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:46167/api/Visitor/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<VisitorViewModel>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateVisitor(VisitorViewModel visitorViewModel)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(visitorViewModel);
            StringContent stringContent = new(jsonData, System.Text.Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:46167/api/Visitor", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return Redirect("/Admin/VisitorApi/Index");
            }
            return View();
        }
}
}
