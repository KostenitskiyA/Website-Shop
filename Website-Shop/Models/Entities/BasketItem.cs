namespace Website_Shop.Models.Entities
{
    /// <summary>
    /// Элемент корзины
    /// </summary>
    public class BasketItem
    {
        /// <summary>
        /// Идентификатор элемента корзины
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Количество продуктов
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Идентификатор корзины
        /// </summary>
        public int BasketId { get; set; }

        /// <summary>
        /// Ссылка на корзину
        /// </summary>
        public Basket Basket { get; set; }

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
