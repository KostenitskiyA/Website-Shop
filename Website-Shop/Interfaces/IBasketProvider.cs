using System.Threading.Tasks;
using Website_Shop.Models.Entities;

namespace Website_Shop.Interfaces
{
    /// <summary>
    /// Провайдер действий с корзиной
    /// </summary>
    public interface IBasketProvider
    {
        /// <summary>
        /// Получение корзины
        /// </summary>
        /// <param name="basketId">Идентификатор корзины</param>
        /// <returns>Корзина</returns>
        public Task<Basket> GetBasketAsync(int basketId);

        /// <summary>
        /// Добавление элемента в корзину
        /// </summary>
        /// <param name="basketId">Идентификатор корзины</param>
        /// <param name="itemId">Идентификатор продукта</param>
        public Task AddItemAsync(int basketId, int itemId);

        /// <summary>
        /// Удаление элемента корзины
        /// </summary>
        /// <param name="itemId">Идентификатор элемента корзины</param>
        public Task DeleteItemAsync(int itemId);

        /// <summary>
        /// Удаление всех элементов корзины
        /// </summary>
        /// <param name="basketId">Идентификатор корзины</param>
        public Task DeleteItemsAsync(int basketId);
    }
}
