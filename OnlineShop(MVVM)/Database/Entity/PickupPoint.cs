namespace OnlineShop_MVVM_.Database.Entity
{
    // Пункты выдачи
    public class PickupPoint
    {
        public int ID { get; set; }
        public string Location { get; set; }
        public int Turnover { get; set; }
        public decimal Rating { get; set; }
    }
}
