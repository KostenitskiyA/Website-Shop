using System.Collections.Generic;
using System.Threading.Tasks;
using Website_Shop.Models.Entities;

namespace Website_Shop.Interfaces
{
    /// <summary>
    /// Провайдер действий с пользователем
    /// </summary>
    public interface IUserProvider
    {
        /// <summary>
        /// Получение пользователя
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>Пользователь</returns>
        public Task<User> GetUserAsync(int userId);

        /// <summary>
        /// Получение пользователей
        /// </summary>
        /// <returns>Коллекция пользователей</returns>
        public Task<IEnumerable<User>> GetUsersAsync();

        /// <summary>
        /// Добавление пользователя
        /// </summary>
        /// <param name="user">Добавленный пользователь</param>
        public Task AddUserAsync(User user);

        /// <summary>
        /// Редактирование пользователя
        /// </summary>
        /// <param name="user">Отредактированный пользователь</param>
        public Task EditUserAsync(User user);

        /// <summary>
        /// Удаление пользователя
        /// </summary>
        /// <param name="userId">Удалённый пользователь</param>
        public Task DeleteUserAsync(int userId);
    }
}
