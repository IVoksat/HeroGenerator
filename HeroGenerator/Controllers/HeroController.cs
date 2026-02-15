using HeroGenerator.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace HeroGenerator.Controllers
{
    public class HeroController(IHeroService heroService) : Controller
    {
        public IActionResult Index()
        {
            return View(heroService.GetAllHeroes());
        }
    }
}
