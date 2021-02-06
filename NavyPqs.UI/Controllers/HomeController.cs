using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NavyPqs.Ui.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NavyPqs.Domain.Interfaces;
using NavyPqs.Domain.Models;

namespace NavyPqs.Ui.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger logger;
        private readonly IOfficerService officerService;

        public HomeController(ILogger logger, IOfficerService officerService)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
            this.officerService = officerService ?? throw new ArgumentNullException(nameof(officerService));
        }

        public IActionResult Index()
        {
            List<Officer> officers = officerService.GetOfficers();
            List<OfficerViewModel> officersVm = officers.Select(officer => new OfficerViewModel(officer)).ToList();
            var vm = new OfficersViewModel(officersVm);
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
