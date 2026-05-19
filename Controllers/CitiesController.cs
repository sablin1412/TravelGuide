using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelGuide.Data;

namespace TravelGuide.Controllers
{
    public class CitiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cities
        public async Task<IActionResult> Index(string? searchString, string? search)
        {
            // Ловим запрос с любым именем (search или searchString)
            string query = searchString ?? search ?? "";
            
            // 1. Выгружаем ВСЕ города в оперативную память, чтобы обойти баг SQLite!
            var allCities = await _context.Cities.ToListAsync();

            if (string.IsNullOrWhiteSpace(query))
            {
                ViewData["CurrentFilter"] = "";
                return View(allCities);
            }

            // 2. Делаем поисковый запрос маленькими буквами
            string lowerQuery = query.Trim().ToLower();
            
            // 3. Ищем, переводя названия из базы тоже в маленькие буквы
            var filteredCities = allCities
                .Where(c => c.Name != null && c.Name.ToLower().Contains(lowerQuery))
                .ToList();

            ViewData["CurrentFilter"] = query;
            return View(filteredCities);
        }

        // GET: Cities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var city = await _context.Cities
                .Include(c => c.Attractions)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (city == null) return NotFound();

            return View(city);
        }
    }
}
