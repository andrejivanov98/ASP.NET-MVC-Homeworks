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
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<ProductViewModel> Products = new List<ProductViewModel>();
            {
                List<Phone> Phones = StaticDB.phones;
                List<Laptop> Laptops = StaticDB.laptops;
                List<Pc> Pcs = StaticDB.pcs;


            }
            
            return View(Products);

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
