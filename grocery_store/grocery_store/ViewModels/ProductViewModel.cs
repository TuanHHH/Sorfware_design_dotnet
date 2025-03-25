using grocery_store.Models;

namespace grocery_store.ViewModels
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
