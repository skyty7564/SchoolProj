using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BartenderMangement.Models;

namespace BartenderMangement.Controllers
{
    public class OrderController : Controller
    {

        public OrderRepository repository;

        public OrderController(OrderRepository repo)
        {
            repository = repo;
        }

        public ViewResult Order()
        {
            return View(repository.Order);
        }


        public ViewResult CreateCocktail(string name)
        {
            ViewBag.name = name;

            return View();
        }
        public ViewResult Index(string name)
        {
            int y = 0;
            Order temp = repository.Order.Last();
            if (temp.OrderID > y)
            {
                y = 1+ temp.OrderID;
            }
            Order New_Order = new Order()
            {
                DrinkName = name,
                OrderID = y,
                DrinkModification = "none", Time = DateTime.Now,
                FinishCheck = "Not"
               
            };

            repository.SaveOrder(New_Order);
            return View();
    
   
        }
    }
}