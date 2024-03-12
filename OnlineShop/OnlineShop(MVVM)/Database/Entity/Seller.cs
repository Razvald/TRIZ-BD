namespace OnlineShop_MVVM_.Database.Entity
{
    // Продавцы
    public class Seller
    {
        public int SellerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Rating { get; set; }

        public static Seller[] GetSellers()
        {
            var sellers = new Seller[]
            {
                new Seller { SellerID = 1, Name = "Иванов Иван", Email = "ivanov@example.com", Rating = 4.2m },
                new Seller { SellerID = 2, Name = "Петров Петр", Email = "petrov@example.com", Rating = 4.0m },
                new Seller { SellerID = 3, Name = "Сидорова Анна", Email = "sidorova@example.com", Rating = 3.1m },
                new Seller { SellerID = 4, Name = "Козлов Дмитрий", Email = "kozlov@example.com", Rating = 4.8m },
                new Seller { SellerID = 5, Name = "Михайлова Елена", Email = "mikhaylova@example.com", Rating = 3.9m }
            };
            return sellers;
        }
    }
}
