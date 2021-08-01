using System.Collections.Generic;

namespace Website_Shop.Models
{
    /// <summary>
    /// Тип пользователя
    /// </summary>
    public class UserType
    {
        /// <summary>
        /// Идентификатор типа
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя типа
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Коллекция профилей
        /// </summary>
        public List<Profile> Profiles { get; set; }
    }
}