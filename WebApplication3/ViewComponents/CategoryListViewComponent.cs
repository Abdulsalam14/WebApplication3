using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using WebApplication3.Data;
using WebApplication3.Services;

namespace WebApplication3.ViewComponents
{
    public class CategoryListViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public CategoryListViewComponent(ICategoryService categoryService)
        {
           _categoryService = categoryService;
        }

        public ViewViewComponentResult Invoke()
        {
            var categories = _categoryService.GetAllCategoriesAsync().Result.Select(c =>
            {
                return new CategoryViewModel
                {
                    Title = c.Title,
                };
            });

            return View(
                new CategoryListViewModel
                {
                    Categories = categories.ToList()
                });
        }
    }
}
