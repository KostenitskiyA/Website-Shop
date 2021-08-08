using System.Collections.Generic;

namespace Website_Shop.Models.Entities
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
        /// Идентификатор пользователя
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Ссылка на пользователя
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Коллекция продуктов
        /// </summary>
        public List<BasketItem> Items { get; set; }
    }
}
