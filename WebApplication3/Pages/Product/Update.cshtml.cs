using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.Services;

namespace WebApplication3.Pages.Product
{
    public class UpdateModel : PageModel
    {
        private readonly IProductService _productService;

        public UpdateModel(IProductService productService)
        {
            _productService = productService;
        }

        [BindProperty]
        public Entities.Product? Product { get; set; }

        public async Task  OnGetAsync(int id)
        {
            Product = await _productService.GetProductByIdAsync(id);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _productService.UpdateProductAsync(Product!);
            string Info= $"{Product!.Name} updated successfully";
            return RedirectToPage("Index", new { info = Info });
        }
    }
}
