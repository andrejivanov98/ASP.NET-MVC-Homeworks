using Microsoft.AspNetCore.Mvc;
using SEDC.E_store.App.Models.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.E_store.App.Controllers
{
    public class LaptopController : Controller
    {
        public IActionResult LaptopDetails(int id)
        {
            if (id > 0)
            {
                var product = StaticDB.laptops.FirstOrDefault(x => x.Id == id);
                if (product == null)
                {
                    return View("ResourceNotFound");
                }

                var mappedModel = LaptopMapper.LaptopToLaptopDetailsViewModel(product);

                return View(mappedModel);
            }

            return View("Error");
        }

    }
}

