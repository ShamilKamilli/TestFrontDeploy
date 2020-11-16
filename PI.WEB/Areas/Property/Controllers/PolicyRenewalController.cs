using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PI.WEB.Areas.Property.Controllers
{
    [Area("Property")]
    [Route("Property/[controller]/[action]")]
    public class PolicyRenewalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CallOrder()
        {
            return View();
        }

        public IActionResult Success()
        {
            return View();
        }

        public IActionResult Payment()
        {
            return View();
        }
    }
}
