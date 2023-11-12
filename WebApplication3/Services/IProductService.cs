using WebApplication3.Entities;

namespace WebApplication3.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductsAsync();
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(Product product);

        Task<Product> GetProductByIdAsync(int id);

    }
}
