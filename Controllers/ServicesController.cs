using aspnet_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_app.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            var service = new VehicleService();
            service.Id = 1;
            service.Title = "Oil Change";
            service.Description = "Change the oil in your vehicle";
            service.Cost = 50.00m;

            return View(service);
        }
    }
}
