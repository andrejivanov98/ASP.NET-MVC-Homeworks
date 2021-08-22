using Microsoft.AspNetCore.Mvc;
using SEDC.E_store.App.Models.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.E_store.App.Controllers
{
    public class PcController : Controller
    {
        public IActionResult PcDetails(int id)
        {
            if (id > 0)
            {
                var product = StaticDB.pcs.FirstOrDefault(x => x.Id == id);
                if (product == null)
                {
                    return View("ResourceNotFound");
                }

                var mappedModel = PcMapper.PcToPcDetailsViewModel(product);

                return View(mappedModel);
            }

            return View("Error");
        }

    }
}

