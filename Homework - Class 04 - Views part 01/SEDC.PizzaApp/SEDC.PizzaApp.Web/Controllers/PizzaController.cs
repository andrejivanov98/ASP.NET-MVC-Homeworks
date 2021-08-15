using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Web.Models.Domain;
using SEDC.PizzaApp.Web.Models.Enums;
using SEDC.PizzaApp.Web.Models.Mapper;
using SEDC.PizzaApp.Web.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.PizzaApp.Web.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzas = StaticDB.Pizzas;
            List<PizzaViewModel> listOfPizzas = new List<PizzaViewModel>();
           
            foreach(Pizza pizza in pizzas)
            {
                listOfPizzas.Add(PizzaMapper.PizzaToPizzaViewModel(pizza));
            }
            return View(listOfPizzas);

        
        }

        public IActionResult PizzaDetailsView()
        {
            PizzaViewModel newPizza = new PizzaViewModel()
            {
                Id = 1,
                Name = "Calcone",
                IsOnPromotion = true,
                Price = 10
            };

            return View(newPizza);
        }
    }
}
