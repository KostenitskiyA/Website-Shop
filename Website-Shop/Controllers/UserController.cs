using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Website_Shop.Interfaces;
using Website_Shop.Models;
using Website_Shop.Models.Entities;

namespace Website_Shop.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private IUserProvider _userService;

        public UserController(ILogger<UserController> logger, IUserProvider userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetUser(int id)
        {
            try
            {
                var user = await _userService.GetUserAsync(id);

                return View("User", user);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);

                return RedirectToAction("Error", new Error()
                {
                    Text = ex.Message
                });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                var users = await _userService.GetUsersAsync();

                return View("Users", users);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);

                return RedirectToAction("Error", new Error()
                {
                    Text = ex.Message
                });
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditUser(int userId)
        {
            try
            {
                var user = await _userService.GetUserAsync(userId);

                return View("EditUser", user);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);

                return RedirectToAction("Error", new Error()
                {
                    Text = ex.Message
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(User user)
        {
            try
            {
                await _userService.EditUserAsync(user);

                return RedirectToAction("GetUsers", "User");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);

                return RedirectToAction("Error", new Error()
                {
                    Text = ex.Message
                });
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeleteUser(int userId)
        {
            try
            {
                await _userService.DeleteUserAsync(userId);

                return RedirectToAction("GetUsers", "User");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);

                return RedirectToAction("Error", new Error()
                {
                    Text = ex.Message
                });
            }
        }
    }
}