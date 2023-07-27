using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroupWebApp.Data;
using RunGroupWebApp.Data.Interfaces;
using RunGroupWebApp.Models;
using RunGroupWebApp.Repository;

namespace RunGroupWebApp.Controllers
{
    public class RaceController : Controller
    {
        IRaceRepository _raceRepocitory;
        public RaceController(IRaceRepository raceRepository)
        {
            _raceRepocitory = raceRepository;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Race> races = await _raceRepocitory.GetAll();
            return View(races);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Race club = await _raceRepocitory.GetByIdAsync(id);
            return View(club);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Race race)
        {
            if (!ModelState.IsValid)
            {
                return View(race);
            }
            _raceRepocitory.Add(race);
            return RedirectToAction("Index");
        }
    }
}
