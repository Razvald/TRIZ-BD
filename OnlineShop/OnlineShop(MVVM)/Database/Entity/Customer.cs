namespace OnlineShop_MVVM_.Database.Entity
{
    // Клиенты
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int TotalOrders { get; set; }

        public static Customer[] GetCustomers()
        {
            var customer = new Customer[]
            {
                new Customer { CustomerID = 1, Name = "Александр Смирнов", Email = "smirnov@example.com", TotalOrders = 1 },
                new Customer { CustomerID = 2, Name = "Екатерина Иванова", Email = "ivanova@example.com", TotalOrders = 1 },
                new Customer { CustomerID = 3, Name = "Максим Петров", Email = "petrov@example.com", TotalOrders = 1 },
                new Customer { CustomerID = 4, Name = "Ольга Сидорова", Email = "sidorova@example.com", TotalOrders = 1 },
                new Customer { CustomerID = 5, Name = "Иван Козлов", Email = "kozlov@example.com", TotalOrders = 1 }

            };
            return customer;
        }
    }
}
