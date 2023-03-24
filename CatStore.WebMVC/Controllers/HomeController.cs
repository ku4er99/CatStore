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

        public IActionResult Index(string term = "", bool paging = false, int currentPage = 1)
        {
            var allPets = _petService.GetPetListVM(term, true, currentPage);
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
