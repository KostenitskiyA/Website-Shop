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
    public class ProductProvider : IProductProvider
    {
        private ApplicationContext _context;

        public ProductProvider(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<Product> GetProductAsync(int productId)
        {
            try
            {
                var product = await _context.Products
                    .Include(p => p.Category)
                    .Include(p => p.Manufacturer)
                    .SingleOrDefaultAsync(p => p.Id == productId);

                return product;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            try
            {
                var products = await _context.Products
                    .Include(p => p.Category)
                    .Include(p => p.Manufacturer)
                    .ToListAsync();

                return products;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task AddProductAsync(Product product)
        {
            try
            {
                _context.Products
                    .Add(product);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task EditProductAsync(Product product)
        {
            try
            {
                _context.Entry(product).State = EntityState.Modified;

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task DeleteProductAsync(int productId)
        {
            try
            {
                var product = _context.Products
                    .SingleOrDefault(p => p.Id == productId);

                _context.Products.Remove(product);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Category> GetCategoryAsync(int categoryId)
        {
            try
            {
                var category = await _context.Categories
                    .SingleOrDefaultAsync(c => c.Id == categoryId);

                return category;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            try
            {
                var categories = await _context.Categories
                    .ToListAsync();

                return categories;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Manufacturer> GetManufacturerAsync(int manufacturerId)
        {
            try
            {
                var manufacturer = await _context.Manufacturers
                    .SingleOrDefaultAsync(m => m.Id == manufacturerId);

                return manufacturer;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Manufacturer>> GetManufacturersAsync()
        {
            try
            {
                var manufacturers = await _context.Manufacturers
                    .ToListAsync();

                return manufacturers;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
