using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelGuide.Data;
using TravelGuide.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelGuide.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string? searchString, string? search)
        {
            string query = searchString ?? search ?? "";
            var allCities = await _context.Cities.ToListAsync();

            Console.WriteLine($"\n========== ДИАГНОСТИКА ПОИСКА ==========");
            Console.WriteLine($"[1] Пользователь ищет: '{query}'");

            if (string.IsNullOrWhiteSpace(query))
            {
                ViewData["CurrentFilter"] = "";
                return View(allCities);
            }

            string lowerQuery = query.Trim().ToLower();
            var filteredCities = new List<City>();

            foreach (var city in allCities)
            {
                if (string.IsNullOrEmpty(city.Name)) continue;
                string dbName = city.Name.Trim().ToLower();
                if (dbName.Contains(lowerQuery))
                {
                    filteredCities.Add(city);
                }
            }

            Console.WriteLine($"[2] Найдено совпадений: {filteredCities.Count}");
            Console.WriteLine($"========================================\n");

            ViewData["CurrentFilter"] = query;
            return View(filteredCities);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            var city = await _context.Cities.Include(c => c.Attractions).FirstOrDefaultAsync(m => m.Id == id);
            if (city == null) return NotFound();
            return View(city);
        }
    }
}