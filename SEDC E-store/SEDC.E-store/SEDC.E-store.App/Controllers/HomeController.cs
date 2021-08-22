using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SEDC.E_store.App.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SEDC.E_store.App.Models.Domain;
using SEDC.E_store.App.Models.ViewModels;
using SEDC.E_store.App.Models.Mappers;

namespace SEDC.E_store.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ProductViewModel products = new ProductViewModel();
            products.Phones = StaticDB.phones;
            products.Laptops = StaticDB.laptops;
            products.Pcs = StaticDB.pcs;

            return View(products);

        }

        public IActionResult Promotions()
        {
            ProductViewModel products = new ProductViewModel();
            products.Phones = StaticDB.phones;
            products.Laptops = StaticDB.laptops;
            products.Pcs = StaticDB.pcs;

            return View(products);
  
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Contact()
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
