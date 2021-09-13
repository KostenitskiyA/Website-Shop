using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Website_Shop.Interfaces;
using Website_Shop.Models;
using Website_Shop.Models.Entities;
using Website_Shop.Models.ViewModels;

namespace Website_Shop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private IProductProvider _productService;

        public ProductController(ILogger<ProductController> logger, IProductProvider productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProduct(int productId)
        {
            try
            {
                var viewModel = new ProductViewModel() 
                {
                    Product = await _productService.GetProductAsync(productId)
                };

                return View("Product", viewModel);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);

                return RedirectToAction("Error", "Error", new Error()
                {
                    Text = ex.Message
                });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            try
            {
                var viewModel = new ProductsViewModel()
                {
                    Products = await _productService.GetProductsAsync()
                };

                return View("Products", viewModel);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);

                return RedirectToAction("Error", "Error", new Error()
                {
                    Text = ex.Message
                });
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditProduct(int productId)
        {
            try
            {
                var viewModel = new EditProductViewModel() 
                {
                    Product = await _productService.GetProductAsync(productId),
                    Categories = await _productService.GetCategoriesAsync(),
                    Manufacturers = await _productService.GetManufacturersAsync()
                };

                return View("EditProduct", viewModel);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);

                return RedirectToAction("Error", "Error", new Error()
                {
                    Text = ex.Message
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditProduct(Product product)
        {
            try
            {
                await _productService.EditProductAsync(product);

                return RedirectToAction("GetProducts", "Product");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);

                return RedirectToAction("Error", "Error", new Error()
                {
                    Text = ex.Message
                });
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeleteProduct(int productId)
        {
            try
            {
                await _productService.DeleteProductAsync(productId);

                return RedirectToAction("GetProducts", "Product");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);

                return RedirectToAction("Error", "Error", new Error()
                {
                    Text = ex.Message
                });
            }
        }
    } 
}
