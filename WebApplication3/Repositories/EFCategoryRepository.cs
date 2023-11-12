using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.Entities;

namespace WebApplication3.Repositories
{
    public class EFCategoryRepository : ICategoryRepository
    {

        private readonly ProductDBContext _dbContext;

        public EFCategoryRepository(ProductDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Category>> GetAllAsync()
        {
            return await _dbContext.Categories.ToListAsync();
        }


    }
}
