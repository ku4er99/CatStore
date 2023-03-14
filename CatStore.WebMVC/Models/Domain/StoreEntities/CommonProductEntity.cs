using CatStore.WebMVC.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace CatStore.WebMVC.Models.Domain.StoreEntities
{
    /// <summary>
    /// Общее представление товара магазина
    /// </summary>
    public abstract class CommonProductEntity
    {
        protected CommonProductEntity() {

        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Заголовок
        /// </summary>
        [Required]
        public string? Title { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        [Required]
        public int? Price { get; set; }
        /// <summary>
        /// Картинка (ex. Image001.png)
        /// </summary>
        [Required]
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
    }
}
