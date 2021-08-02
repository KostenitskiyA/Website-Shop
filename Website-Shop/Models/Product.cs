using System.Collections.Generic;

namespace Website_Shop.Models
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
        /// Название продукта
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание продукта
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Идентификатор категории
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Ссылка на категорию
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Идентификатор производителя
        /// </summary>
        public int ManufacturerId { get; set; }

        /// <summary>
        /// Ссылка на производителя
        /// </summary>
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