using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleShoppingSite.Models;
using SimpleShoppingSite.Repositories.Interfaces;

namespace SimpleShoppingSite.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly IProduct productService;

        public IndexModel(IProduct productService)
        {
            this.productService = productService;
        }

        public List<Product> Products { get; set; }

        public int MaxPage { get; set; }

        public void OnGet(int page)
        {
            if (page < 1) 
                page = 1;
            Products = productService.GetAllAsync(page, 5);
            MaxPage = productService.Count() / 5;
        }
    }
}
