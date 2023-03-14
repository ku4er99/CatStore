using Microsoft.AspNetCore.Mvc.Rendering;

namespace CatStore.WebMVC.Models.DTO.Pets
{
    public class AddPetViewModel
    {
        public int SelectedKind { get; set; } 
        public List<SelectListItem> PetKindsSelectList { get; set; }
    }
}
