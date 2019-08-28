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
    }
}