using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website_Shop.Interfaces;
using Website_Shop.Models;
using Website_Shop.Models.Entities;

namespace Website_Shop.Services
{
    public class OrderProvider : IOrderProvider
    {
        private ApplicationContext _context;

        public OrderProvider(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<Order> GetOrderAsync(int orderId)
        {
            try
            {
                var order = await _context.Orders
                    .Include(o => o.Items)
                    .SingleOrDefaultAsync(o => o.Id == orderId);

                return order;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Order>> GetOrdersAsync()
        {
            try
            {
                var orders = await _context.Orders
                    .Include(o => o.Items)
                    .ToListAsync();

                return orders;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Order>> GetOrdersAsync(int userId)
        {
            try
            {
                var orders = await _context.Orders
                    .Include(o => o.Items)
                    .Where(o => o.UserId == userId)
                    .ToListAsync();

                return orders;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task AddOrderAsync(Order order)
        {
            try
            {
                _context.Orders.Add(order);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task DeleteOrderAsync(int orderId)
        {
            try
            {
                var order = await GetOrderAsync(orderId);

                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Statuses> GetStatusAsync(int orderId)
        {
            try
            {
                var order = await GetOrderAsync(orderId);

                return order.Status;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task SetStatusAsync(int orderId, Statuses status)
        {
            try
            {
                var order = await GetOrderAsync(orderId);

                order.Status = status;

                _context.Entry(order).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
