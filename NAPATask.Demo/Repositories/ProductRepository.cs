using Microsoft.EntityFrameworkCore;
using NAPATask.Demo.Data;
using NAPATask.Demo.Interfaces.IRepositories;
using NAPATask.Demo.Models;
using System.Linq.Expressions;

namespace NAPATask.Demo.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _dbSet;

        public ProductRepository( ApplicationDbContext dbContext)
        {
            _dbSet = dbContext;
        }

        public async Task<Product> CreateAsync(Product product)
        {
            var newproduct = await _dbSet.Products.AddAsync(product);
            return newproduct.Entity;
        }

        public  Task DeleteAsync(Product product)
            => Task.FromResult(_dbSet.Remove(product));
      
        public IQueryable<Product> GetAll(Expression<Func<Product, bool>>? expression = null, bool isTracking = true)
        {
            var sources = expression is null ? _dbSet.Products : _dbSet.Products.Where(expression);

            return isTracking ? sources : sources.AsNoTracking();
        }

        public async Task<Product?> GetAsync(Expression<Func<Product, bool>> expression)
            => await _dbSet.Products.FirstOrDefaultAsync(expression);

        public async Task UpdateAsync(Product product)
            => _dbSet.Update(product);
       
    }
}
