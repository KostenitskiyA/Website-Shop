using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Website_Shop.Interfaces;
using Website_Shop.Models;
using Website_Shop.Models.Entities;

namespace Website_Shop.Services
{
    public class BasketProvider : IBasketProvider
    {
        private ApplicationContext _context;

        public BasketProvider(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<Basket> GetBasketAsync(int basketId)
        {
            try
            {
                var basket = await _context.Baskets
                    .Include(b => b.Items)
                    .ThenInclude(i => i.Product)
                    .SingleOrDefaultAsync(b => b.Id == basketId);

                return basket;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task AddProductAsync(int basketId, int productId)
        {
            try
            {
                var newItem = new BasketItem()
                {
                    Count = 1,
                    BasketId = basketId,
                    ProductId = productId
                };

                _context.BasketItems.Add(newItem);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task DeleteItemAsync(int itemId)
        {
            try
            {
                var foundItem = await _context.BasketItems
                    .SingleOrDefaultAsync(i => i.Id == itemId);

                _context.BasketItems.Remove(foundItem);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task DeleteItemsAsync(int basketId)
        {
            try
            {
                var foundItems = await _context.BasketItems
                    .Where(i => i.BasketId == basketId)
                    .ToListAsync();

                _context.BasketItems.RemoveRange(foundItems);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
