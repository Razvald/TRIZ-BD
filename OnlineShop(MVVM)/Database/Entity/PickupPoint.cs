namespace OnlineShop_MVVM_.Database.Entity
{
    // Пункты выдачи
    public class PickupPoint
    {
        public int PickupPointID { get; set; }
        public string Location { get; set; }
        public int Turnover { get; set; }
        public decimal Rating { get; set; }

        public static PickupPoint[] GetPickupPoints()
        {
            var pickupPoints = new PickupPoint[]
            {
                new PickupPoint { PickupPointID = 1, Location = "ул. Ленина, 10", Turnover = 1, Rating = 3.9M },
                new PickupPoint { PickupPointID = 2, Location = "пр. Победы, 25", Turnover = 2, Rating = 4.2M },
                new PickupPoint { PickupPointID = 3, Location = "пр. Советская, 5", Turnover = 1, Rating = 3.2M },
                new PickupPoint { PickupPointID = 4, Location = "пр. Мира, 15", Turnover = 1, Rating = 5.0M },
                new PickupPoint { PickupPointID = 5, Location = "пр. Гагарина, 30", Turnover = 1, Rating = 4.0M }
            };
            return pickupPoints;
        }
    }
}
