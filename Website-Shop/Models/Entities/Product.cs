using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Website_Shop.Models.Entities
{
    /// <summary>
    /// Продукт
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Идентификатор продукта
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование продукта
        /// </summary>
        [Display(Name = "Наименование продукта")]
        [Required(ErrorMessage = "Не указано наименование продукта")]
        public string Name { get; set; }

        /// <summary>
        /// Описание продукта
        /// </summary>
        [Display(Name = "Описание продукта")]
        public string Description { get; set; }

        /// <summary>
        /// Идентификатор категории
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Ссылка на категорию
        /// </summary>
        [Display(Name = "Категория продукта")]
        [Required(ErrorMessage = "Не указана категория продукта")]
        public Category Category { get; set; }

        /// <summary>
        /// Идентификатор производителя
        /// </summary>
        public int ManufacturerId { get; set; }

        /// <summary>
        /// Ссылка на производителя
        /// </summary>
        [Display(Name = "Производитель продукта")]
        [Required(ErrorMessage = "Не указан производитель продукта")]
        public Manufacturer Manufacturer { get; set; }

        /// <summary>
        /// Коллекция элементов корзины
        /// </summary>
        public List<BasketItem> BasketItems { get; set; }

        /// <summary>
        /// Коллекция элементов заказов
        /// </summary>
        public List<OrderItem> OrderItems { get; set; }
    }
}