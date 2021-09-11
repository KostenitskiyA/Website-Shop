using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Website_Shop.Interfaces;
using Website_Shop.Models;
using Website_Shop.Models.Entities;

namespace Website_Shop.Controllers
{
    public class AuthorizationController : Controller
    {
        private readonly ILogger<AuthorizationController> _logger;
        private IAuthorizationProvider _authorizationService;

        public AuthorizationController(ILogger<AuthorizationController> logger, IAuthorizationProvider authorizationService)
        {
            _logger = logger;
            _authorizationService = authorizationService;
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View(new User());
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(User user)
        {
            try
            {
                var foundUser = await _authorizationService.LogInAsync(user);

                if (foundUser == null)
                    throw new Exception("Пользователь не найден");

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(Authorization(user.Authorization.Login, user.Role.ToString())));

                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);

                ModelState.AddModelError("", ex.Message);

                return View();
            }
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View(new User());
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(User user)
        {
            try
            {
                var createdUser = await _authorizationService.SignInAsync(user);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(Authorization(createdUser.Authorization.Login, createdUser.Role.ToString())));

                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);

                ModelState.AddModelError("", ex.Message);

                return View();
            }
        }

        [HttpGet]
        public IActionResult LogOut()
        {
            try
            {
                HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);

                return RedirectToAction("Index", "Error", new Error()
                {
                    Text = ex.Message
                });
            }
        }

        private ClaimsIdentity Authorization(string login, string role)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, login),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, role)
            };

            return new ClaimsIdentity(claims,
                "ApplicationCookie",
                ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
        }
    }
}
