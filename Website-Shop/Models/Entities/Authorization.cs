using System.ComponentModel.DataAnnotations;

namespace Website_Shop.Models.Entities
{
    /// <summary>
    /// Авторизация
    /// </summary>
    public class Authorization
    {
        /// <summary>
        /// Идентификатор авторизации
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Логин
        /// </summary>
        [Display(Name = "Логин")]
        [Required(ErrorMessage = "Не указан логин")]
        public string Login { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        [Display(Name = "Пароль")]
        [Required(ErrorMessage = "Не указан пароль")]
        public string Password { get; set; }

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Ссылка на пользователя
        /// </summary>
        public User User { get; set; }
    }
}