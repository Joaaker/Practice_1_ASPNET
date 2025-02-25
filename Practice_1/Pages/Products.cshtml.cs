using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Business.Services;
using Business.Models;

namespace Practice_1.Pages
{
    public class ProductsModel : PageModel
    {
        public List<Product> Products { get; set; } = [];
        public void OnGet()
        {
            Products = ProductService.GetProducts();

        }
    }
}
