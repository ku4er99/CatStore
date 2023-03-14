using CatStore.WebMVC.Models.Domain.StoreEntities;
using CatStore.WebMVC.Models.Domain.StoreEntities.PetEntities;

namespace CatStore.WebMVC.Repositories.Abstract {
    public interface IPetService {

        bool Add(PetEntity product, out string errorMsg);
        bool Update(PetEntity product);
        bool Delete(int id);
        PetEntity GetById(int id);
        IQueryable<PetEntity> GetAll();

    }
}
