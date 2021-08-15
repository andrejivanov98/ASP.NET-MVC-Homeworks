using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.Web.Models.Domain;
using SEDC.PizzaApp.Web.Models.ViewModels;


namespace SEDC.PizzaApp.Web.Models.Mapper
{
    public class PizzaMapper
    {
        public static PizzaViewModel PizzaToPizzaViewModel(Pizza pizza)
        {
            return new PizzaViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name,
                IsOnPromotion = pizza.IsOnPromotion,
                Price = pizza.Price

            };


        }
    }
}
