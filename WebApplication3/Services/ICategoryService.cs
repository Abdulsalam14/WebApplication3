using WebApplication3.Entities;
using WebApplication3.Repositories;

namespace WebApplication3.Services
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllCategoriesAsync();
    }
}
