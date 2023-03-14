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
        private readonly IFileService _fileService;

        public PetController(IPetService petService, IFileService fileService) {
            _petService = petService;
            _fileService = fileService;
        }

        public IActionResult AddPet() {
            return View();
        }

        [HttpPost]
        public IActionResult AddPet(PetEntity petModel) {   
           
            if (!ImageIsFilling(petModel)) {
                TempData["msg"] = "Файл не выбран";
                return View(petModel);
            }
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
        private bool ImageIsFilling(PetEntity petModel) {
            if(petModel.ImageFile != null) {
                var fileResult = _fileService.SaveImage(petModel.ImageFile);
                if(fileResult.Item1 == 0) {
                    return false;
                }
                var imageName = fileResult.Item2;
                petModel.Image = imageName;
                return true;
            }
            return false;
        }
        public IActionResult EditPet(int id) {
            var data = _petService.GetById(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Update(PetEntity petModel) {
            
            if(!ImageIsFilling(petModel)) {
                TempData["msg"] = "Файл не выбран";
                return RedirectToAction(nameof(EditPet), new { id = petModel.Id });
            }
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
