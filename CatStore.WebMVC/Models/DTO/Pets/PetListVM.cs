using CatStore.WebMVC.Models.Domain.StoreEntities.PetEntities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CatStore.WebMVC.Models.DTO.Pets
{
    public class PetListVM
    {
        public IQueryable<PetEntity> Pets { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public string Term { get; set; } = string.Empty;
    }
}
