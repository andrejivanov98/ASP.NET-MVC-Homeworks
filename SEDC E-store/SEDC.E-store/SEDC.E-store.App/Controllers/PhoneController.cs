using Microsoft.AspNetCore.Mvc;
using SEDC.E_store.App.Models.ViewModels;
using SEDC.E_store.App.Models.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.E_store.App.Models.Domain;

namespace SEDC.E_store.App.Controllers
{
    public class PhoneController : Controller
    {
        public IActionResult PhoneDetails(int id)
        {
            if (id > 0)
            {
                Phone product = StaticDB.phones.FirstOrDefault(x => x.Id == id);
                if (product == null)
                {
                    return View("ResourceNotFound");
                }

                PhoneDetailsViewModel mappedModel = PhoneMapper.PhoneToPhoneDetailsViewModel(product);

                return View(mappedModel);
            }

            return View("Error");
        }

    }

        
}
