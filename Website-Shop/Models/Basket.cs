using System.Collections.Generic;

namespace Website_Shop.Models
{
    /// <summary>
    /// Корзина
    /// </summary>
    public class Basket
    {
        /// <summary>
        /// Идентификатор корзины
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Ссылка на профиль
        /// </summary>
        public Profile Profile { get; set; }

        /// <summary>
        /// Коллекция продуктов
        /// </summary>
        public List<BasketItem> Items { get; set; }
    }
}
