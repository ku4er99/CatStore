using CatStore.WebMVC.Common.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatStore.WebMVC.Models.Domain.StoreEntities
{
    /// <summary>
    /// Общее представление товара магазина
    /// </summary>
    public abstract class CommonProductEntity
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Заголовок
        /// </summary>
        [Required]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Цена
        /// </summary>
        [Required]
        public int Price { get; set; }

        /// <summary>
        /// Картинка (ex. Image001.png)
        /// </summary>
        public string? Image { get; set;}

        /// <summary>
        /// Описание товара
        /// </summary>
        [Required]
        public string? Description { get; set; }

        /// <summary>
        /// Тип продукта
        /// </summary>
        [Required]
        public abstract ProductTypes? ProductType { get; }
        
        [Required]
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
