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
    public class UserProvider : IUserProvider
    {
        private ApplicationContext _context;

        public UserProvider(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserAsync(int userId)
        {
            try
            {
                var user = await _context.Users
                    .Include(u => u.Authorization)
                    .Include(u => u.Profile)
                    .SingleOrDefaultAsync(u => u.Id == userId);

                return user;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            try
            {
                var users = await _context.Users
                    .Include(u => u.Authorization)
                    .Include(u => u.Profile)
                    .ToListAsync();

                return users;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task AddUserAsync(User user)
        {
            try
            {
                _context.Users
                    .Add(user);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task EditUserAsync(User user)
        {
            try
            {
                _context.Entry(user).State = EntityState.Modified;
                _context.Entry(user.Authorization).State = EntityState.Modified;
                _context.Entry(user.Profile).State = EntityState.Modified;

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task DeleteUserAsync(int userId)
        {
            try
            {
                var foundUser = _context.Users
                    .SingleOrDefault(u => u.Id == userId);

                _context.Users.Remove(foundUser);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}