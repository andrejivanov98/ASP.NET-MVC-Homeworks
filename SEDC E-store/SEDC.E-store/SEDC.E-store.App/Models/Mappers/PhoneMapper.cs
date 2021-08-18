using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.E_store.App.Models.ViewModels;
using SEDC.E_store.App.Models.Domain;

namespace SEDC.E_store.App.Models.Mappers
{
    public static class PhoneMapper
    {
        public static PhoneDetailsViewModel PhoneToPhoneDetailsViewModel(Phone phone)
        {
            return new PhoneDetailsViewModel
            {
                Id = phone.Id,
                Name = phone.Name,
                Description = phone.Description,
                Category = phone.Category,
                Reviews = phone.Reviews,
                IsOnPromotion = phone.IsOnPromotion
            };
        }
    }
}
