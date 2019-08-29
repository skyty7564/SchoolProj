using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BartenderMangement.Models;
namespace BartenderMangement.Controllers
{
    public class BarController : Controller
    {

        public MenuRepository repository;
      
        public BarController(MenuRepository repo)
        {
            repository = repo;
        }

        [HttpGet]
        public ViewResult Index()
        {
        
            return View();
        }
        [HttpGet]
        public ViewResult Menu()
        {
            return View(repository.Drink);
        }


        
   
        public ViewResult Test(string name)
        {
       
            return View();
        }
    }
}