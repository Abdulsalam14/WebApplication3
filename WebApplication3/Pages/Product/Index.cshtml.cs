using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.Data;
using WebApplication3.Services;

namespace WebApplication3.Pages.Product
{
    public class IndexModel : PageModel
    {
        private readonly IProductService _productService;

        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }

        public List<Entities.Product>? Products { get; set; }
        public async Task OnGet(string info = "")
        {
            Products = await _productService.GetAllProductsAsync();
            Info = info;
        }

        public string? Info { get; set; }

        [BindProperty]
        public Entities.Product? Product { get; set; }


        public async Task<IActionResult> OnPost()
        {
            await _productService.AddProductAsync(Product!);

            Info = $"{Product?.Name} added successfully";
            return RedirectToPage("Index", new { info = Info });
        }
        public async Task<IActionResult> OnGetDelete(int id)
        {
            var deletedProduct = await _productService.GetProductByIdAsync(id);
            await _productService.DeleteProductAsync(deletedProduct);
            Info = $"{deletedProduct.Name} Deleted successfully";
            return RedirectToPage("Index", new { info = Info });
        }
    }
}
