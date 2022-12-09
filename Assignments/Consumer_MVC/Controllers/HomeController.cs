﻿using Consumer_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using ClientNS;
using System.Diagnostics;

namespace Consumer_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        HttpClient client = null;
        string baseUrl = string.Empty;
        ClientProxy proxy = null;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            baseUrl = "https://localhost:7191";
            client = new HttpClient();
            proxy = new ClientProxy(baseUrl, client);
        }

        public async Task<IActionResult> Index()
        {
            var result = await proxy.GetcategoriesAsync();
            //var Cat = new Category()
            //{
            //    CategoryId = 4005,
            //    CategoryName = "MyCat",
            //    BasePrice = 30
            //};
            //var result = await proxy.CreatecategoryAsync(Cat);

            ViewBag.Categories = JsonSerializer.Serialize(result);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}