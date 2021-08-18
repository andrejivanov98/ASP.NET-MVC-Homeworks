using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.E_store.App.Models.Domain;
using SEDC.E_store.App.Models.ViewModels;

namespace SEDC.E_store.App.Models.Mappers
{
    public static class PcMapper
    {
        public static PcDetailsViewModel PcToPcDetailsViewModel(Pc pc)
        {
            return new PcDetailsViewModel
            {
                Id = pc.Id,
                Name = pc.Name,
                Description = pc.Description,
                Category = pc.Category,
                Reviews = pc.Reviews,
                IsOnPromotion = pc.IsOnPromotion

            };
        }
    }
}
