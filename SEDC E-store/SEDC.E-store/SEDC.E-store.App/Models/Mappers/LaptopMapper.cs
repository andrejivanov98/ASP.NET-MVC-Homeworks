using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.E_store.App.Models.ViewModels;
using SEDC.E_store.App.Models.Domain;

namespace SEDC.E_store.App.Models.Mappers
{
    public static class LaptopMapper
    {
        public static LaptopDetailsViewModel LaptopToLaptopDetailsViewModel(Laptop laptop)
        {
            return new LaptopDetailsViewModel
            {
                Id = laptop.Id,
                Name = laptop.Name,
                Description = laptop.Description,
                Category = laptop.Category,
                Reviews = laptop.Reviews,
                IsOnPromotion = laptop.IsOnPromotion
            };
        }
    }
}
