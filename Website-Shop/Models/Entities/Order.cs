using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Website_Shop.Models.Entities
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
        /// Идентификатор пользователя
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Ссылка на пользователя
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Статус заказа
        /// </summary>
        [Display(Name = "Статус заказа")]
        [Required(ErrorMessage = "Не указана статус")]
        public Statuses Status { get; set; }

        /// <summary>
        /// Коллекция продуктов
        /// </summary>
        public List<OrderItem> Items { get; set; }
    }

    /// <summary>
    /// Статусы заказа
    /// </summary>
    public enum Statuses
    {
        Собирается,
        Доставляется,
        Выполнен
    }
}
