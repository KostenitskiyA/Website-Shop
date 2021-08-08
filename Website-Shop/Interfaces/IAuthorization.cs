using Website_Shop.Models.Entities;

namespace Website_Shop.Interfaces
{
    public interface IAuthorization
    {
        /// <summary>
        /// Авторизация пользователя
        /// </summary>
        /// <param name="user">Пользователь для авторизации</param>
        /// <returns>Авторизированный пользователь</returns>
        public User LogIn(User user);

        /// <summary>
        /// Регистрация пользователя
        /// </summary>
        /// <param name="user">Пользователь для регистрации</param>
        /// <returns>Авторизированный пользователь</returns>
        public User SignIn(User user);
    }
}
