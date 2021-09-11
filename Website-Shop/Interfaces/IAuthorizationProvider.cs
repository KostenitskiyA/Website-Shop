using System.Threading.Tasks;
using Website_Shop.Models.Entities;

namespace Website_Shop.Interfaces
{
    /// <summary>
    /// Провайдер действий с авторизацией
    /// </summary>
    public interface IAuthorizationProvider
    {
        /// <summary>
        /// Авторизация пользователя
        /// </summary>
        /// <param name="user">Пользователь для авторизации</param>
        /// <returns>Авторизированный пользователь</returns>
        public Task<User> LogInAsync(User user);

        /// <summary>
        /// Регистрация пользователя
        /// </summary>
        /// <param name="user">Пользователь для регистрации</param>
        /// <returns>Авторизированный пользователь</returns>
        public Task<User> SignInAsync(User user);
    }
}
