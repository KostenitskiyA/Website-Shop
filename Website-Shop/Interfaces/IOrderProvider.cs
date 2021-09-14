using System.Collections.Generic;
using System.Threading.Tasks;
using Website_Shop.Models.Entities;

namespace Website_Shop.Interfaces
{
    /// <summary>
    /// Провайдер действий с заказом
    /// </summary>
    public interface IOrderProvider
    {
        /// <summary>
        /// Получение заказа
        /// </summary>
        /// <param name="orderId">Идентификатор заказа</param>
        /// <returns>Заказ</returns>
        public Task<Order> GetOrderAsync(int orderId);

        /// <summary>
        /// Получение заказов
        /// </summary>
        /// <returns>Коллекция заказов</returns>
        public Task<IEnumerable<Order>> GetOrdersAsync();

        /// <summary>
        /// Получение заказов
        /// </summary>
        /// <param name="userId">Идентификатор пользователя</param>
        /// <returns>Коллекция заказов</returns>
        public Task<IEnumerable<Order>> GetOrdersAsync(int userId);

        /// <summary>
        /// Добавление заказа
        /// </summary>
        /// <param name="order">Добавленный заказ</param>
        public Task AddOrderAsync(Order order);

        /// <summary>
        /// Удаление заказа
        /// </summary>
        /// <param name="orderId">Идентификатор заказа</param>
        public Task DeleteOrderAsync(int orderId);

        /// <summary>
        /// Получение статуса заказа
        /// </summary>
        /// <param name="orderId">Идентификатор заказа</param>
        public Task GetStatusAsync(int orderId);

        /// <summary>
        /// Установка статуса заказа
        /// </summary>
        /// <param name="orderId">Идентификатор заказа</param>
        /// <param name="status">Статус</param>
        public Task SetStatusAsync(int orderId, string status);
    }
}