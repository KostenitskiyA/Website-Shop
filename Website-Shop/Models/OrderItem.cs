namespace Website_Shop.Models
{
    /// <summary>
    /// Элемент заказа
    /// </summary>
    public class OrderItem
    {
        /// <summary>
        /// Идентификатор элемента заказа
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Количество продуктов
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Идентификатор заказа
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Ссылка на заказ
        /// </summary>
        public Order Order { get; set; }

        /// <summary>
        /// Идентификатор продукта
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Ссылка на продукт
        /// </summary>
        public Product Product { get; set; }
    }
}
