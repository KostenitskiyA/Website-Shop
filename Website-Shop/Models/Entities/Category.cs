using System.Collections.Generic;

namespace Website_Shop.Models.Entities
{
    /// <summary>
    /// Категория
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Идентификатор категории
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование категории
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Коллекция продуктов
        /// </summary>
        public List<Product> Products { get; set; } 
    }
}
