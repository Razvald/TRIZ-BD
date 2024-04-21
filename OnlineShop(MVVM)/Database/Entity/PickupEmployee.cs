namespace OnlineShop_MVVM_.Database.Entity
{
    // модель, не сущность
    public class PickupEmployee
    {
        public string EmployeeName { get; set; }
        public string PickupPointLocation { get; set; }
        public int OrdersCount { get; set; }
    }
}
