using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using TraversalProject.PresentationLayer.Areas.Admin.Models;

namespace TraversalProject.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ApiExchangeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var list = new List<BookingExchangeViewModel>();

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(
                    "https://booking-com15.p.rapidapi.com/api/v1/meta/getExchangeRates?base_currency=TRY"),
                Headers =
                {
                    { "x-rapidapi-key", "e71177d867mshfa37763bf5e2e10p1b4212jsn34b1dc08d068" },
                    { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
                },
            };

            using var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var body = await response.Content.ReadAsStringAsync();
            using var jsonDoc = JsonDocument.Parse(body);

            var exchangeRates = jsonDoc
                .RootElement
                .GetProperty("data")
                .GetProperty("exchange_rates");

            foreach (var rate in exchangeRates.EnumerateArray())
            {
                list.Add(new BookingExchangeViewModel
                {
                    currency = rate.GetProperty("currency").GetString(),
                    exchange_rate_buy = rate.GetProperty("exchange_rate_buy").GetString()
                });
            }

            return View(list);
        }
    }
}
