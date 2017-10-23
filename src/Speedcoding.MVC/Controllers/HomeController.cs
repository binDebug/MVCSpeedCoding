using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Speedcoding.MVC.Helpers;
using Speedcoding.MVC.Models;

namespace Speedcoding.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ApiHelper helper = new ApiHelper();
            Person person = helper.Get();
            return View(person);
        }
    }
}