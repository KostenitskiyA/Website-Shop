using System.Collections.Generic;

namespace Website_Shop.Models
{
    /// <summary>
    /// Роль пользователя
    /// </summary>
    public class UserRole
    {
        /// <summary>
        /// Идентификатор роли пользователя
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя роли
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Коллекция профилей
        /// </summary>
        public List<Profile> Profiles { get; set; }
    }
}