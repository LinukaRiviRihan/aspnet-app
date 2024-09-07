using aspnet_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_app.Controllers
{
    public class ServicesController : Controller
    {
        [ViewData]
        public string PageTitle { get; set; }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            PageTitle = "Service Details";

            var service = new VehicleService
            {
                Id = 1,
                Title = "Oil Change",
                Description = "Change the oil in your car",
                Cost = 20.00
            };

            return View(service);
        }
    }
}
