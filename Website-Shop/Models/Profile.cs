namespace Website_Shop.Models
{
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
        /// Идентификатор типа пользователя
        /// </summary>
        public int UserTypeId { get; set; }

        /// <summary>
        /// Ссылка на тип пользователя
        /// </summary>
        public UserType UserType { get; set; }
    }
}
