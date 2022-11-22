﻿using la_mia_pizzeria_static.Data;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            PizzaeriaDbContext db = new PizzaeriaDbContext();

            List<Pizza> listaPizza = db.Pizze.ToList();

            return View(listaPizza);
        }

        public IActionResult Detail(int id)
        {
            PizzaeriaDbContext db = new PizzaeriaDbContext();

            Pizza pizza = db.Pizze.Where(p => p.Id == id).FirstOrDefault();
            return View(pizza);
        }
    }
}
