using OnlineShop_MVVM_.Command;
using OnlineShop_MVVM_.Database;
using OnlineShop_MVVM_.Database.Entity;
using OnlineShop_MVVM_.Models;
using System.Collections.ObjectModel;

namespace OnlineShop_MVVM_.ViewModels
{
    public class StatisticsVM : VMBase
    {
        private readonly AppDbContext _dbContext;
        private StatisticM _statisticM;
        private readonly EmployeeStore _employeeStore;
        private bool _isAdmin;

        public bool IsAdmin
        {
            get { return _isAdmin; }
            set
            {
                if (_isAdmin != value)
                {
                    _isAdmin = value;
                    OnPropertyChanged(nameof(IsAdmin));
                }
            }
        }
        public ObservableCollection<Employee> EmployeesDataList { get; set; } = new ObservableCollection<Employee>();
        public ObservableCollection<PickupPoint> PickupPointsDataList { get; set; } = new ObservableCollection<PickupPoint>();

        public StatisticsVM(AppDbContext dbContext, EmployeeStore employeeStore)
        {
            _dbContext = dbContext;
            _employeeStore = employeeStore;
            _statisticM = new StatisticM();

            empList();
            pointList();

            if (_employeeStore.CurrentEmployee.RoleID != 2)
            {
                IsAdmin = true;
            }
        }

        private void empList()
        {
            var employees = _dbContext.Employees;

            foreach (var emp in employees)
            {
                EmployeesDataList.Add(emp);
            }
        }

        private void pointList()
        {
            var pickupPoints = _dbContext.PickupPoints;

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

        //public ICommand Filter { get; set; }
        //public ICommand PropertyChanged { get; set; }
    }
}
