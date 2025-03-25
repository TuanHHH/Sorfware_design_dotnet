using grocery_store.Data;
//using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
//using grocery_store.Data;
using grocery_store.Models;
namespace grocery_store.Controllers
{
    //public class CartController : Controller
    //{
    //private readonly AppDbContext _context;

    //public CartController(AppDbContext context)
    //{
    //    _context = context;
    //}

    //public async Task<IActionResult> Index()
    //{
    //    var cartItems = await _context.CartItems.ToListAsync();
    //    return View(cartItems);
    //}

    //[HttpPost]
    //public async Task<IActionResult> AddItem(string productId)
    //{
    //    if (!string.IsNullOrEmpty(productId))
    //    {
    //        _context.CartItems.Add(new Cart { ProductId = productId });
    //        await _context.SaveChangesAsync();
    //    }
    //    return RedirectToAction("Index");
    //}

    //[HttpPost]
    //public async Task<IActionResult> RemoveItem(int id)
    //{
    //    var item = await _context.CartItems.FindAsync(id);
    //    if (item != null)
    //    {
    //        _context.CartItems.Remove(item);
    //        await _context.SaveChangesAsync();
    //    }
    //    return RedirectToAction("Index");
    //}

    //}
    public class CartController : Controller
    {
        private readonly AppDbContext _context;

        public CartController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Cart
        public async Task<IActionResult> Index()
        {
            // Lấy tất cả các CartItems từ cơ sở dữ liệu
            var cartItems = await _context.cart.ToListAsync();

            // Nếu không có dữ liệu, trả về lỗi hoặc thông báo
            if (cartItems == null)
            {
                return View("Error", new { message = "Không có CartItems trong cơ sở dữ liệu." });
            }

            return View(cartItems); // Trả về danh sách CartItems
        }
    }
}
