namespace OnlineShop_MVVM_.Database.Entity
{
    // Сотрудники
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Salary { get; set; }
        public int PickupPointID { get; set; }

        public IEnumerable<PickupPoint> PickupPoint { get; set; }

        public static Employee[] GetEmployees()
        {
            var employees = new Employee[]
            {
                new Employee { EmployeeID = 1, Name = "Андрей Кузнецов", Login = "andreyk", Password = "123456", Salary = 12000, PickupPointID = 1 },
                new Employee { EmployeeID = 2, Name = "Мария Васильева", Login = "mariav", Password = "qwerty", Salary = 15000, PickupPointID = 2 },
                new Employee { EmployeeID = 3, Name = "Сергей Попов", Login = "sergeyp", Password = "654321", Salary = 10000, PickupPointID = 3 },
                new Employee { EmployeeID = 4, Name = "Елена Новикова", Login = "elenan", Password = "123", Salary = 11000, PickupPointID = 4 },
                new Employee { EmployeeID = 5, Name = "Алексей Иванов", Login = "alekseyi", Password = "321", Salary = 13000, PickupPointID = 5 }
            };
            return employees;
        }
    }
}
