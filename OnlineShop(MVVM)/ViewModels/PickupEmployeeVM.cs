using OnlineShop_MVVM_.Database.Entity;
using OnlineShop_MVVM_.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace OnlineShop_MVVM_.ViewModels
{
    public class PickupEmployeeVM : ViewModelBase
    {
        private PickupEmployeeM _pickupEmployeeM;
        public ObservableCollection<PickupEmployee> CombinedDataList { get; set; } = new ObservableCollection<PickupEmployee>();

        public PickupEmployeeVM()
        { 
            _pickupEmployeeM = new PickupEmployeeM();

            var employees = Employee.GetEmployees();
            var pickupPoints = PickupPoint.GetPickupPoints();
            var orders = Order.GetOrders();

            var ordersSummary = from employee in employees
                                join pickupPoint in pickupPoints on employee.PickupPointID equals pickupPoint.PickupPointID
                                join order in orders on pickupPoint.PickupPointID equals order.PickupPointID
                                where order.PickupPointID == employee.PickupPointID // Фильтруем заказы только для текущего сотрудника
                                group order by new { employee.Name, pickupPoint.Location } into groupedOrders
                                select new PickupEmployee
                                {
                                    EmployeeName = groupedOrders.Key.Name,
                                    PickupPointLocation = groupedOrders.Key.Location,
                                    OrdersCount = groupedOrders.Count() // Подсчитываем количество заказов для каждой группы
                                };

            foreach (var item in ordersSummary)
            {
                CombinedDataList.Add(item);
            }
        }

        public string Search
        {
            get { return _pickupEmployeeM.Search; }
            set { _pickupEmployeeM.Search = value; OnPropertyChanged(nameof(Search)); }
        }

        public ICommand Filter { get; set; }
        public ICommand PropertyChanged { get; set; }
    }
}
