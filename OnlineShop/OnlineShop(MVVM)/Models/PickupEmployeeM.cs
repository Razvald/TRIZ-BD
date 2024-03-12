using OnlineShop_MVVM_.Database.Entity;

namespace OnlineShop_MVVM_.Models
{
    public class PickupEmployeeM
    {
        public string Search { get; set; }
        public IEnumerable<PickupEmployee> EmployeesOrders { get; set; }
    }
}