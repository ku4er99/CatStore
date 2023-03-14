using CatStore.WebMVC.Models.Domain;
using CatStore.WebMVC.Models.Domain.StoreEntities;
using CatStore.WebMVC.Models.Domain.StoreEntities.PetEntities;
using CatStore.WebMVC.Repositories.Abstract;

namespace CatStore.WebMVC.Repositories.Implementation {
    public class PetService : IPetService {

        private readonly DatabaseContext Context;
        public PetService(DatabaseContext context) {
               this.Context = context;
        }

        public bool Add(PetEntity product, out string errorMsg) {
            try {
                Context.Pets.Add(product);
                Context.SaveChanges();
                errorMsg = string.Empty;
                return true;
            } catch(Exception ex) {
                errorMsg = ex.Message;
                return false;
            }
        }

        public bool Delete(int id) {
            try {
                var pet = Context.Pets.Find(id);
                Context.Pets.Remove(pet);
                Context.SaveChanges();
                return true;
            } catch(Exception ex) {
                return false;
            }
        }

        public IQueryable<PetEntity> GetAll() {
            return Context.Pets.AsQueryable();
        }

        public PetEntity GetById(int id) {
            return Context.Pets.Find(id);
        }

        public bool Update(PetEntity product) {
            try {
                Context.Pets.Update(product);
                Context.SaveChanges();
                return true;
            } catch(Exception ex) {
                return false;
            }
        }
    }
}
