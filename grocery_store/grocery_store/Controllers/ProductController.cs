
using grocery_store.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace grocery_store.Controllers
{
    public class ProductController:Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        // GET: Cart
        public async Task<IActionResult> Index()
        {
            
            var productItems = await _context.products.ToListAsync();

            
            if (productItems == null)
            {
                return View("Error", new { message = "Không có CartItems trong cơ sở dữ liệu." });
            }

            return View(productItems); 
        }
    }
}
