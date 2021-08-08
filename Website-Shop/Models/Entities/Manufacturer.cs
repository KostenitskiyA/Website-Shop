using System.Collections.Generic;

namespace Website_Shop.Models.Entities
{
    /// <summary>
    /// Производитель
    /// </summary>
    public class Manufacturer
    {
        /// <summary>
        /// Идентификатор производителя
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование производителя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Коллекция продуктов
        /// </summary>
        public List<Product> Products { get; set; }
    }
}
