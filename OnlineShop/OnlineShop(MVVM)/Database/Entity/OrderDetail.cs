namespace OnlineShop_MVVM_.Database.Entity
{
    // Детали заказа
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public int Subtotal { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }

        public static OrderDetail[] GetOrderDetails()
        {
            var orderDetails = new OrderDetail[]
            {
                new OrderDetail { OrderDetailID = 1, OrderID = 1, ProductID = 4, Quantity = 4, Subtotal = 12000 },
                new OrderDetail { OrderDetailID = 2, OrderID = 2, ProductID = 16, Quantity = 2, Subtotal = 20000 },
                new OrderDetail { OrderDetailID = 3, OrderID = 3, ProductID = 8, Quantity = 14, Subtotal = 28000 },
                new OrderDetail { OrderDetailID = 4, OrderID = 2, ProductID = 11, Quantity = 1, Subtotal = 1000 },
                new OrderDetail { OrderDetailID = 5, OrderID = 4, ProductID = 20, Quantity = 6, Subtotal = 42000 },
                new OrderDetail { OrderDetailID = 6, OrderID = 5, ProductID = 1, Quantity = 2, Subtotal = 15000 }
            };
            return orderDetails;
        }
    }
}
