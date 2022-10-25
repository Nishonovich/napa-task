using NAPATask.Demo.Helpers;
using NAPATask.Demo.Models;
using NAPATask.Demo.ViewModel.Products;
using System.Linq.Expressions;

namespace NAPATask.Demo.Interfaces.Services
{
    public interface IProductService
    {
        public ValueTask<Result<IEnumerable<Product>>> GetAllAsync();
        public Result<Product> GetByIdAsync(long productId);
        public ValueTask<Result<Product>> DeleteProduct(long productId);
        public ValueTask<Result<Product>> UpdateProduct(long productId, Product product);
        public ValueTask<Result<Product>> CreateProduct(Product product);
    
    }
}
