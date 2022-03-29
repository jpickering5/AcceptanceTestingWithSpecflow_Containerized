using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Product.Api.Data;

namespace Product.Api.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Models.Product> CreateAsync(Models.Product product)
        {
            await _dbContext.Products.AddAsync(product);
            await _dbContext.SaveChangesAsync();
            return product;
        }

        public async Task<Models.Product> GetAsync(Guid productId)
        {
            return await _dbContext.Products.FindAsync(productId);
        }

        public async Task DeleteAsync(Guid productId)
        {
            var product = await GetAsync(productId);
            if (product is null)
            {
                return;
            }
            _dbContext.Products.Remove(product);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<Models.Product>> GetAllAsync()
        {
            return await _dbContext.Products.ToListAsync();
        }
    }
}
