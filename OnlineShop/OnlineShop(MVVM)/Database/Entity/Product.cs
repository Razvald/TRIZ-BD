namespace OnlineShop_MVVM_.Database.Entity
{
    // Продукты
    public class Product
    {
        public int ProductID { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int SellerID { get; set; }
        public decimal Rating { get; set; }

        public IEnumerable<Seller> Seller { get; set; }

        public static Product[] GetProducts()
        {
            var products = new Product[]
            {
                new Product { ProductID = 1, Title = "Ноутбук Dell XPS 13", Price = 15000, Quantity = 10, SellerID = 1, Rating = 4.2m },
                new Product { ProductID = 2, Title = "Смартфон iPhone 12", Price = 10000, Quantity = 15, SellerID = 2, Rating = 3.2m },
                new Product { ProductID = 3, Title = "Телевизор Samsung QLED 55\"", Price = 1200, Quantity = 8, SellerID = 3, Rating = 5 },
                new Product { ProductID = 4, Title = "Наушники Sony WH-1000XM4", Price = 3000, Quantity = 20, SellerID = 4, Rating = 4.5m },
                new Product { ProductID = 5, Title = "Кофемашина DeLonghi Magnifica", Price = 6000, Quantity = 12, SellerID = 5, Rating = 4.8m },
                new Product { ProductID = 6, Title = "Планшет Samsung Galaxy Tab S7", Price = 8000, Quantity = 18, SellerID = 1, Rating = 4.3m },
                new Product { ProductID = 7, Title = "Фотоаппарат Canon EOS R5", Price = 25000, Quantity = 5, SellerID = 2, Rating = 4.2m },
                new Product { ProductID = 8, Title = "Беспроводные наушники Apple AirPods Pro", Price = 2500, Quantity = 25, SellerID = 3, Rating = 4.2m },
                new Product { ProductID = 9, Title = "Умные часы Garmin Forerunner 945", Price = 6000, Quantity = 10, SellerID = 4, Rating = 4 },
                new Product { ProductID = 10, Title = "Холодильник LG InstaView", Price = 15000, Quantity = 8, SellerID = 5, Rating = 4 },
                new Product { ProductID = 11, Title = "Умные колонки Amazon Echo", Price = 1000, Quantity = 30, SellerID = 1, Rating = 3.3m },
                new Product { ProductID = 12, Title = "Видеокарта NVIDIA GeForce RTX 3080", Price = 12000, Quantity = 15, SellerID = 2, Rating = 4.5m },
                new Product { ProductID = 13, Title = "Фитнес трекер Fitbit Charge 4", Price = 1500, Quantity = 20, SellerID = 3, Rating = 4.8m },
                new Product { ProductID = 14, Title = "Соковыжималка Bosch MESM731M", Price = 2000, Quantity = 10, SellerID = 4, Rating = 4.3m },
                new Product { ProductID = 15, Title = "Ноутбук Apple MacBook Pro 13\"", Price = 18000, Quantity = 7, SellerID = 5, Rating = 3.8m },
                new Product { ProductID = 16, Title = "Квадрокоптер DJI Mavic Air 2", Price = 10000, Quantity = 12, SellerID = 1, Rating = 4 },
                new Product { ProductID = 17, Title = "Монитор LG UltraGear 27GN950-B", Price = 7000, Quantity = 10, SellerID = 2, Rating = 3.2m },
                new Product { ProductID = 18, Title = "Кофеварка DeLonghi Dedica", Price = 1500, Quantity = 15, SellerID = 3, Rating = 5 },
                new Product { ProductID = 19, Title = "Умный термостат Nest Learning Thermostat", Price = 2500, Quantity = 8, SellerID = 4, Rating = 4.2m },
                new Product { ProductID = 20, Title = "Смарт-часы Apple Watch Series 6", Price = 7000, Quantity = 6, SellerID = 5, Rating = 4.2m }
            };
            return products;
        }
    }
}
