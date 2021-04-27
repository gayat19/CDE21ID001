using FirstCoreApplication.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApplication.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private HomeService _homeService;

        public HomeController(HomeService homeService)
        {
            _homeService = homeService;
        }
        [Route("Index")]
        public IActionResult Index()
        {
            ViewBag.Message = _homeService.GiveGreet();
            return View();
        }
    }
}
