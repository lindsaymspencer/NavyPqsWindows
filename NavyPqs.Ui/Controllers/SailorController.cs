using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NavyPqs.Domain.Interfaces;
using NavyPqs.Domain.Models;
using NavyPqs.Ui.Models;

namespace NavyPqs.Ui.Controllers
{
    public class SailorController : Controller
    {
        private readonly ILogger logger;
        private readonly ISailorService sailorService;

        public SailorController(ILogger logger, ISailorService sailorService)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
            this.sailorService = sailorService ?? throw new ArgumentNullException(nameof(sailorService));
        }

        // GET: Sailor
        public async Task<IActionResult> Index()
        {
            List<Sailor> sailors = sailorService.GetSailors();
            return View(sailors.Select(SailorViewModel.CreateFrom).ToList());
        }

        // GET: Sailor/Details/5
        public async Task<IActionResult> Details(int id)
        {
            Sailor sailor = sailorService.GetSailor(id);
            return View(SailorViewModel.CreateFrom(sailor));
        }

        // GET: Sailor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sailor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Rank,FirstName,LastName")] SailorViewModel sailorViewModel)
        {
            if (ModelState.IsValid)
            {
                var response = sailorService.CreateSailor(sailorViewModel.Rank, sailorViewModel.FirstName,
                    sailorViewModel.LastName);
                if (response) return RedirectToAction(nameof(Index));
            }

            logger.LogError(
                $"Create failed. {sailorViewModel.Rank} {sailorViewModel.FirstName} {sailorViewModel.LastName}");
            return View(sailorViewModel);
        }

        // GET: Sailor/Edit/5
        public async Task<IActionResult> Edit(int id, bool x)
        {
            ViewData["EditSailor"] = x;
            var sailor = sailorService.GetSailor(id);
            if (sailor == null)
            {
                // TODO: Create this page.
                return NotFound();
            }
            var sailorViewModel = SailorViewModel.CreateFrom(sailor);
            return View(sailorViewModel);
        }

        // POST: Sailor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Rank,FirstName,LastName,Pqses")] SailorViewModel sailorViewModel)
        {
            if (id != sailorViewModel.Id) return NotFound();
            if (!ModelState.IsValid) return View(sailorViewModel);


            var sailor = new Sailor(sailorViewModel.Id, sailorViewModel.Rank, sailorViewModel.FirstName, sailorViewModel.LastName, );
            var response = sailorService.EditSailor(id, sailor);
            if (response) return RedirectToAction(nameof(Index));
            logger.LogError(
                $"Edit failed. {sailorViewModel.Rank} {sailorViewModel.FirstName} {sailorViewModel.LastName}");
            return View(sailorViewModel);
        }

        // GET: Sailor/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var sailor = sailorService.GetSailor(id);
            if (sailor == null) return NotFound();

            return View(SailorViewModel.CreateFrom(sailor));
        }

        // POST: Sailor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var response = sailorService.DeleteSailor(id);
                if (response) return RedirectToAction(nameof(Index));
                logger.LogError($"Delete failed for ID: {id}.");
            }
            catch (Exception ex)
            {
                logger.LogError($"Exception for ID: {id}, {ex.Message}.");
            }

            return RedirectToAction(nameof(Index));
        }
    }
}