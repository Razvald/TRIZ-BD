﻿namespace OnlineShop_MVVM_.Database.Entity
{
    // Клиенты
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int TotalOrders { get; set; }
    }
}
