namespace CatStore.WebMVC.Models.Domain.StoreEntities {
    public class Order {

        public int Id { get; set; }

        public int ApplicationUserId { get; set; }

        public ICollection<CommonProductEntity> Products { get; set; }

    }
}
