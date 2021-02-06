using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NavyPqs.Ui.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NavyPqs.Domain.Models;
using NavyPqs.Ui.Models;

namespace NavyPqs.Ui.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly OfficerService officerService;

        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;

            officerService = new OfficerService();
        }

        public IActionResult Index()
        {
            List<Officer> officers = officerService.GetOfficers();
            var officersVM = new List<OfficerViewModel>();

            foreach (var officer in officers)
            {
                officersVM.Add(new OfficerViewModel(officer));
            }

            var vm = new OfficersViewModel(officersVM);

            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
