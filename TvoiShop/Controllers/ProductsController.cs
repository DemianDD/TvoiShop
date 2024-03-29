﻿using Duende.IdentityServer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using TvoiShop.Infrastructure;
using TvoiShop.Infrastructure.Services;
using TvoiShop.Models;
using static System.Net.Mime.MediaTypeNames;

namespace TvoiShop.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet]
        public Task<List<Product>> GetAll()
        {
            return _productsService.GetAll();
        }

        [Authorize]
        [HttpPost]
        public void AddProduct(Product item)
        {
            _productsService.AddProduct(item);
        }

        [Authorize]
        [HttpDelete]
        public void DeleteProductById(Guid id)
        {
            _productsService.DeleteProductById(id);
        }

        [Authorize]
        [HttpPatch]
        public void UpdateProduct(Product item)
        {
            _productsService.UpdateProduct(item);
        }
    }
}
