using OnlineShop_MVVM_.Database.Entity;

namespace OnlineShop_MVVM_.Models
{
    public class ProductsM
    {
        public string Search { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
