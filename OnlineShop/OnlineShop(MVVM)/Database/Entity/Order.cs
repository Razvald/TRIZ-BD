namespace OnlineShop_MVVM_.Database.Entity
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public int TotalAmount { get; set; }
        public int PickupPointID { get; set; }

        public IEnumerable<Customer> Customer { get; set; }
        public IEnumerable<PickupPoint> PickupPoint { get; set; }

        public static Order[] GetOrders()
        {
            var orders = new Order[]
            {
                new Order { OrderID = 1, CustomerID = 1, OrderDate = new DateTime(2024, 2, 5), TotalAmount = 12000, PickupPointID = 1 },
                new Order { OrderID = 2, CustomerID = 2, OrderDate = new DateTime(2024, 2, 4), TotalAmount = 21000, PickupPointID = 2 },
                new Order { OrderID = 3, CustomerID = 3, OrderDate = new DateTime(2024, 2, 3), TotalAmount = 28000, PickupPointID = 3 },
                new Order { OrderID = 4, CustomerID = 4, OrderDate = new DateTime(2024, 2, 2), TotalAmount = 42000, PickupPointID = 4 },
                new Order { OrderID = 5, CustomerID = 5, OrderDate = new DateTime(2024, 2, 1), TotalAmount = 15000, PickupPointID = 5 },
                new Order { OrderID = 6, CustomerID = 2, OrderDate = new DateTime(2024, 2, 1), TotalAmount = 11000, PickupPointID = 2 }
            };
            return orders;
        }
    }
}
