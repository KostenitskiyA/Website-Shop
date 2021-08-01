using System.Collections.Generic;

namespace Website_Shop.Models
{
    /// <summary>
    /// Заказ
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Идентификатор заказа
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор профиля
        /// </summary>
        public int ProfileId { get; set; }

        /// <summary>
        /// Ссылка на профиль
        /// </summary>
        public Profile Profile { get; set; }

        /// <summary>
        /// Коллекция продуктов
        /// </summary>
        public List<OrderItem> Items { get; set; }
    }
}
