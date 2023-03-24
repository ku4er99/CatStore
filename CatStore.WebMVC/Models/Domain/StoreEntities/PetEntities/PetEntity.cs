using CatStore.WebMVC.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace CatStore.WebMVC.Models.Domain.StoreEntities.PetEntities
{
    /// <summary>
    /// Модель продаваемого домашнего животного
    /// </summary>
    public class PetEntity : CommonProductEntity
    {
        public PetEntity() { }

        #region Overrides

        /// <summary>
        /// Тип продукта
        /// </summary>
        [Required]
        public override ProductTypes? ProductType { get; }

        #endregion

        #region Abstract

        /// <summary>
        /// Тип домашнего животного
        /// </summary>
        [Required]
        public PetKinds? PetKind { get; set; }

        #endregion

        /// <summary>
        /// Имя питомца
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Кол-во лет
        /// </summary>
        [Required]
        public int? Age { get; set; }

        /// <summary>
        /// Флаг игривости
        /// </summary>
        [Required]
        public bool IsPlayful { get; set; }

        /// <summary>
        /// Флаг любвиобильности
        /// </summary>
        [Required]
        public bool IsLoving { get; set; }
    }
}
