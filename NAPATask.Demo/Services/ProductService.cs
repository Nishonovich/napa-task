using NAPATask.Demo.Helpers;
using NAPATask.Demo.Interfaces.Services;
using NAPATask.Demo.Models;

namespace NAPATask.Demo.Services
{
    public class ProductService : IProductService
    {
        private readonly ILogger<ProductService> _logger;
        private readonly IConfiguration _configuration;

        public ProductService(ILogger<ProductService> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public ValueTask<Result<Product>> CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Result<Product>> DeleteProduct(long productId)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Result<IEnumerable<Product>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Result<Product> GetByIdAsync(long productId)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Result<Product>> UpdateProduct(long productId, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
