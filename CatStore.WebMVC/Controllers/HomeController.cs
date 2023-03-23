using CatStore.WebMVC.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CatStore.WebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPetService _petService;

        public HomeController(IPetService petService)
        {
            _petService = petService;
        }

        public IActionResult Index()
        {
            var allPets = _petService.GetAll();
            return View(allPets);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult PetDetail(int petId) {
            var pet = _petService.GetById(petId);
            return View(pet);
        }
    }
}
