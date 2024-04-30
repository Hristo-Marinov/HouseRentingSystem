using HouseRent.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HouseRent.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}