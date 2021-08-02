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
        /// Коллекция элементов корзины
        /// </summary>
        public List<BasketItem> BasketItems { get; set; }

        /// <summary>
        /// Коллекция элементов заказов
        /// </summary>
        public List<OrderItem> OrderItems { get; set; }
    }
}