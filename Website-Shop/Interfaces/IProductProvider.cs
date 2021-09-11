using System.Collections.Generic;
using System.Threading.Tasks;
using Website_Shop.Models.Entities;

namespace Website_Shop.Interfaces
{
    /// <summary>
    /// Провайдер действий с товарами
    /// </summary>
    public interface IProductProvider
    {
        /// <summary>
        /// Получение продукта
        /// </summary>
        /// <param name="productId"></param>
        /// <returns>Продукт</returns>
        public Task<Product> GetProductAsync(int productId);

        /// <summary>
        /// Получение коллекции товаров
        /// </summary>
        /// <returns>Коллекция товаров</returns>
        public Task<IEnumerable<Product>> GetProductsAsync();

        /// <summary>
        /// Добавление товара
        /// </summary>
        /// <param name="product">Добавленный товар</param>
        public Task AddProductAsync(Product product);

        /// <summary>
        /// Редактирование товара
        /// </summary>
        /// <param name="product">Отредактированный товар</param>
        public Task EditProductAsync(Product product);

        /// <summary>
        /// Удаление товара
        /// </summary>
        /// <param name="productId">Удалённый товар</param>
        public Task DeleteProductAsync(int productId);

        /// <summary>
        /// Получение категории
        /// </summary>
        /// <param name="categoryId">Идентификатор категории</param>
        /// <returns>Категория</returns>
        public Task<Category> GetCategoryAsync(int categoryId);

        /// <summary>
        /// Получение коллекции категорий
        /// </summary>
        /// <returns>Коллекция категорий</returns>
        public Task<IEnumerable<Category>> GetCategoriesAsync();

        /// <summary>
        /// Получение производителя
        /// </summary>
        /// <param name="manufacturerId">Идентификатор производителя</param>
        /// <returns>Производитель</returns>
        public Task<Manufacturer> GetManufacturerAsync(int manufacturerId);

        /// <summary>
        /// Получение коллекции производителей
        /// </summary>
        /// <returns>Коллекция производителей</returns>
        public Task<IEnumerable<Manufacturer>> GetManufacturersAsync();
    }
}
