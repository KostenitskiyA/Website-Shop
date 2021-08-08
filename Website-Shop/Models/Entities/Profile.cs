using System.ComponentModel.DataAnnotations;

namespace Website_Shop.Models.Entities
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
        [Display(Name = "ФИО")]
        [Required(ErrorMessage = "Не указано имя")]
        public string Name { get; set; }

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