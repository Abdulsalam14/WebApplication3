using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.Entities;

namespace WebApplication3.Repositories
{
    public class EFProductRepository : IProductRepository
    {
        private readonly ProductDBContext _dbContext;

        public EFProductRepository(ProductDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Product product)
        {
            await _dbContext.Products.AddAsync(product);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Product product)
        {
            var DeleteProduct = await _dbContext.Products.FindAsync(product.Id);
           if(DeleteProduct != null) { 
                _dbContext.Remove(DeleteProduct);
                await _dbContext.SaveChangesAsync();
            }
        }


        public async Task<List<Product>> GetAllAsync()
        {
            return await _dbContext.Products.ToListAsync();
        }

        public async Task UpdateAsync(Product product)
        {
            var UpdateProduct = await _dbContext.Products.FindAsync(product.Id);
            if (UpdateProduct is not null)
            {
                UpdateProduct.Name = product.Name;
                UpdateProduct.Price = product.Price;
                _dbContext.Update(UpdateProduct);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
