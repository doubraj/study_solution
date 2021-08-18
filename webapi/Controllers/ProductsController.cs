using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi.Data;
using webapi.Models;

namespace webapi.Controllers
{
    public class ProductsController : BaseApiController
    {
        private readonly DataContext _context;

        public ProductsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> getAllProducts()
        {
            return await _context.Products.ToListAsync();
        }
        // TODO: Get all v2 (support for pagination)
        // TODO: Get one by ID
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> getProductById(Guid id)
        {
            return await _context.Products.FindAsync(id);
        }
        // TODO: Update one by ID
        [HttpPut("{id}")]
        public ActionResult<Product> updateProductDescriptionById(Guid id, Product product)
        {
            // Test implementation
            // TODO: implement real logic
            Console.WriteLine(product.Description);
            return new Product
            {
                Id = new Guid(),
                Name = "pocitac",
                ImgUri = "asdfasdfasdf.jpg",
                Price = 199,
                Description = ""
            };
        }
    }
}