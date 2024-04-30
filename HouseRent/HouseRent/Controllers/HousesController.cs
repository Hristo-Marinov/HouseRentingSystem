using HouseRent.Models;
using Microsoft.AspNetCore.Mvc;

namespace HouseRent.Controllers
{
    public class HousesController : Controller
    {
        public IActionResult All()
        {
            var model = new AllHousesViewModel
            {
                Houses = Common.GetAllHouses()
            };
            return View(model);
        }

        public IActionResult Details()
        {
            var house = Common.GetAllHouses().FirstOrDefault();
            return View(house);
        }
    }
}
