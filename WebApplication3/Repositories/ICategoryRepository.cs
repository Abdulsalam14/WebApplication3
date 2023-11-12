using WebApplication3.Entities;

namespace WebApplication3.Repositories
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAllAsync();
    }
}
