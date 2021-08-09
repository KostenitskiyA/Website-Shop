using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Website_Shop.Interfaces;
using Website_Shop.Models;
using Website_Shop.Models.Entities;

namespace Website_Shop.Services
{
    public class Authorization : IAuthorization
    {
        private ApplicationContext _context;

        public Authorization(ApplicationContext context)
        {
            _context = context;
        }

        public User LogIn(User user)
        {
            try
            {
                var foundUser = _context.Users
                    .Include(u => u.Authorization)
                    .Where(u => u.Authorization.Login == user.Authorization.Login
                          && u.Authorization.Password == user.Authorization.Password)
                    .FirstOrDefault();

                return foundUser;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public User SignIn(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();

                return user;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
