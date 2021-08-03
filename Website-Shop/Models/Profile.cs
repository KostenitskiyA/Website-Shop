using System.Collections.Generic;

namespace Website_Shop.Models
{
    /// <summary>
    /// Профиль
    /// </summary>
    public class Profile
    {
        /// <summary>
        /// Идентификатор профиля
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя профиля
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Ссылка на пользователя
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Идентификатор роли пользователя
        /// </summary>
        public int UserRoleId { get; set; }

        /// <summary>
        /// Ссылка на роль пользователя
        /// </summary>
        public UserRole UserRole { get; set; }

        /// <summary>
        /// Идентификатор корзины
        /// </summary>
        public int BasketId { get; set; }

        /// <summary>
        /// Ссылка на корзину
        /// </summary>
        public Basket Basket { get; set; }

        /// <summary>
        /// Коллекция заказов
        /// </summary>
        public List<Order> Orders { get; set; }
    }
}