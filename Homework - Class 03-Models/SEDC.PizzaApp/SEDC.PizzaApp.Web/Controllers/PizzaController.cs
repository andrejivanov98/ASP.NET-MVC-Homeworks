using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Web.Models.Domain;
using SEDC.PizzaApp.Web.Models.Enums;
using SEDC.PizzaApp.Web.Models.Mapper;
using SEDC.PizzaApp.Web.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.PizzaApp.Web.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index(int id)
        {

            List<Pizza> pizzas = StaticDB.Pizzas;
            List<PizzaViewModel> pizzaDetails = new List<PizzaViewModel>();

            foreach (Pizza pizza in pizzas)
            {
                pizzaDetails.Add(PizzaMapper.PizzaToPizzaViewModel(pizza));
            }

            Pizza newPizza = new Pizza()
            {
                Id = 4,
                Name = "Vegetarijana",
                Price = 6,
                IsOnPromotion = true,
                HasExtras = true,
                PizzaSize = PizzaSize.Normal
            };

            pizzaDetails.Add(PizzaMapper.PizzaToPizzaViewModel(newPizza));

            ViewData.Add("Title", "List of Pizzas");
            return View(pizzaDetails);
        }

        public IActionResult Details(int id)
        {
            List<Pizza> pizzas = StaticDB.Pizzas;
            List<PizzaViewModel> pizzaDetails = new List<PizzaViewModel>();
            foreach (Pizza pizza in pizzas)
            {
                pizzaDetails.Add(PizzaMapper.PizzaToPizzaViewModel(pizza));
            }

            foreach (PizzaViewModel pizza in pizzaDetails)
            {
                if (pizza.Id == id)
                {

                    ViewData.Add("Title", "Pizza name");
                    ViewBag.PizzaViewModel = pizza;
                    return View();
                }


            }
            return new EmptyResult();

        }



    }
}
