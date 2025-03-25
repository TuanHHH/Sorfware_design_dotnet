
using grocery_store.Data;
using grocery_store.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Printing;
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
        //public async Task<IActionResult> Index()
        //{

        //    var productItems = await _context.products.ToListAsync();


        //    if (productItems == null)
        //    {
        //        return View("Error", new { message = "Không có CartItems trong cơ sở dữ liệu." });
        //    }

        //    return View(productItems); 
        //}

        private const int PageSize = 18;
        public IActionResult ProductView(int page = 1)
        {
            
        // Lấy tổng số sản phẩm
            var productCount = _context.products.Count();

            // Lấy danh sách sản phẩm cho trang hiện tại
            var products = _context.products
                .Skip((page - 1) * PageSize)
                .Take(PageSize)
                .ToList();

            // Tính toán tổng số trang
            var totalPages = (int)Math.Ceiling((double)productCount / PageSize);

            // Truyền dữ liệu vào View
            var model = new ProductViewModel
            {
                Products = products,
                CurrentPage = page,
                TotalPages = totalPages
            };

            return View("ProductView",model);
        }
    }
}
