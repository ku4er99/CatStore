using CatStore.WebMVC.Common;
using CatStore.WebMVC.Common.Enums;
using CatStore.WebMVC.Models.Domain.StoreEntities.PetEntities;
using CatStore.WebMVC.Models.DTO.Pets;
using CatStore.WebMVC.Repositories.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CatStore.WebMVC.Controllers {
    [Authorize]
    public class PetController : Controller {

        private readonly IPetService _petService;
        public PetController(IPetService petService) {
           _petService = petService;
        }

        public IActionResult AddPet() {
            return View();
        }

        [HttpPost]
        public IActionResult AddPet(PetEntity petModel) {   
            var errorMsg = String.Empty;
            var result = _petService.Add(petModel, out errorMsg);
            if (result) {
                TempData["msg"] = CommonResources.Common_Added;
                return RedirectToAction(nameof(AddPet));
            } else {
                TempData["msg"] = errorMsg;
                return View(petModel);
            }
            
        }

        public IActionResult EditPet(int id) {
            var data = _petService.GetById(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Update(PetEntity petModel) {
            if(!ModelState.IsValid) { return View(petModel); }

            var result = _petService.Update(petModel);
            if(result) {
                TempData["msg"] = CommonResources.Common_Updated;
                return RedirectToAction(nameof(GetAllPets));
            } else {
                TempData["msg"] = CommonResources.Common_ServerSideError;
                return View(petModel);
            }

        }

        public IActionResult GetAllPets() {
            var data = _petService.GetAll().ToList();
            return View(data);
        }

        public IActionResult DeletePet(int id) {
            var result = _petService.Delete(id);
            if(result) {
                TempData["msg"] = CommonResources.Common_Deleted;
                return RedirectToAction(nameof(GetAllPets));
            } else {
                TempData["msg"] = CommonResources.Common_ServerSideError;
                return View();
            }

        }
    }
}
