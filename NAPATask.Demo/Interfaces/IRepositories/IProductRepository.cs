using NAPATask.Demo.Models;
using System.Linq.Expressions;

namespace NAPATask.Demo.Interfaces.IRepositories
{
    public interface IProductRepository
    {
        Task<Product> CreateAsync(Product product);

        Task UpdateAsync(Product product);

        Task DeleteAsync(Product product);

        Task<Product?> GetAsync(Expression<Func<Product, bool>> expression);

        IQueryable<Product> GetAll(Expression<Func<Product, bool>>? expression = null, bool isTracking = true);
    }
}
