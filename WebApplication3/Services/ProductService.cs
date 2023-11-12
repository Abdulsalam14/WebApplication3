using WebApplication3.Entities;
using WebApplication3.Repositories;

namespace WebApplication3.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task AddProductAsync(Product product)
        {
            await _productRepository.AddAsync(product);
        }

        public async Task DeleteProductAsync(Product product)
        {
            await _productRepository.DeleteAsync(product);
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var products = await _productRepository.GetAllAsync();
            var result = products.FirstOrDefault(p => p.Id == id)!;
            return result;
        }

        public async Task UpdateProductAsync(Product product)
        {
            await _productRepository.UpdateAsync(product);
        }
    }
}
