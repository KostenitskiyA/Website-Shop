using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Website_Shop.Models.Entities
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Ссылка на авторизацию
        /// </summary>
        public Authorization Authorization { get; set; }

        /// <summary>
        /// Ссылка на профиль
        /// </summary>
        public Profile Profile { get; set; }

        /// <summary>
        /// Роль пользователя
        /// </summary>
        [Display(Name = "Роль пользователя")]
        [Required(ErrorMessage = "Не указана роль")]
        public Roles Role { get; set; }

        /// <summary>
        /// Ссылка на корзину
        /// </summary>
        public Basket Basket { get; set; }

        /// <summary>
        /// Коллекция заказов
        /// </summary>
        public List<Order> Orders { get; set; }
    }

    /// <summary>
    /// Роли пользователя
    /// </summary>
    public enum Roles
    {
        Покупатель,
        Продавец,
        Администратор
    }
}