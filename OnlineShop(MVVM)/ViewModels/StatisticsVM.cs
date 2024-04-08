using OnlineShop_MVVM_.Database.Entity;
using OnlineShop_MVVM_.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace OnlineShop_MVVM_.ViewModels
{
    public class StatisticsVM : ViewModelBase
    {
        private StatisticM _statisticM;
        public ObservableCollection<Employee> EmployeesDataList { get; set; } = new ObservableCollection<Employee>();
        public ObservableCollection<PickupPoint> PickupPointsDataList { get; set; } = new ObservableCollection<PickupPoint>();

        public StatisticsVM()
        {
            _statisticM = new StatisticM();

            empList();
            pointList();
        }

        private void empList()
        {
            var employees = Employee.GetEmployees();

            foreach (var emp in employees)
            {
                EmployeesDataList.Add(emp);
            }
        }

        private void pointList()
        {
            var pickupPoints = PickupPoint.GetPickupPoints();

            foreach (var emp in pickupPoints)
            {
                PickupPointsDataList.Add(emp);
            }
        }

        public string SearchPoint
        {
            get { return _statisticM.SearchPoint; }
            set { _statisticM.SearchPoint = value; OnPropertyChanged(nameof(SearchPoint)); }
        }

        public string SearchEmp
        {
            get { return _statisticM.SearchEmp; }
            set { _statisticM.SearchEmp = value; OnPropertyChanged(nameof(SearchEmp)); }
        }

        public ICommand Filter { get; set; }
        public ICommand PropertyChanged { get; set; }
    }
}
