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
    public class AuthorizationProvider : IAuthorizationProvider
    {
        private ApplicationContext _context;

        public AuthorizationProvider(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<User> LogInAsync(User user)
        {
            try
            {
                var foundUser = await _context.Users
                    .Include(u => u.Authorization)
                    .Where(u => u.Authorization.Login == user.Authorization.Login
                          && u.Authorization.Password == user.Authorization.Password)
                    .FirstOrDefaultAsync();

                return foundUser;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<User> SignInAsync(User user)
        {
            try
            {
                var foundUser = await _context.Authorizations
                    .Where(a => a.Login == user.Authorization.Login)
                    .FirstOrDefaultAsync();

                if (foundUser != null)
                    throw new Exception("Пользователь с таким логином уже существует");

                user.Basket = new Basket();
                user.Orders = new List<Order>();

                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();

                return user;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
