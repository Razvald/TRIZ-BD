﻿using OnlineShop_MVVM_.Command;
using OnlineShop_MVVM_.Database;
using OnlineShop_MVVM_.Database.Entity;
using OnlineShop_MVVM_.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace OnlineShop_MVVM_.ViewModels
{
    public class PickupEmployeeVM : VMBase
    {
        private readonly AppDbContext _dbContext;
        private PickupEmployeeM _pickupEmployeeM;
        private readonly EmployeeStore _employeeStore;
        public ObservableCollection<PickupEmployee> CombinedDataList { get; set; } = new ObservableCollection<PickupEmployee>();
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
        private bool _isSave;

        public bool IsSave
        {
            get { return _isSave; }
            set
            {
                if (_isSave != value)
                {
                    _isSave = value;
                    OnPropertyChanged(nameof(IsSave));
                }
            }
        }

        public PickupEmployeeVM(AppDbContext dbContext, EmployeeStore employeeStore)
        {
            _dbContext = dbContext;
            _employeeStore = employeeStore;
            _pickupEmployeeM = new PickupEmployeeM();

            InitializeCombinedDataList();

            SaveCommand = new SaveCommand(_dbContext);

            if (_employeeStore.CurrentEmployee.RoleID != 2)
            {
                IsAdmin = true;
            }
            IsSave = _employeeStore.CurrentEmployee.RoleID == 2;
        }

        private void InitializeCombinedDataList()
        {
            var employees = _dbContext.Employees;
            var pickupPoints = _dbContext.PickupPoints;
            var orders = _dbContext.Orders;

            var ordersSummary = from employee in employees
                                join pickupPoint in pickupPoints on employee.PickupPointID equals pickupPoint.ID
                                join order in orders on pickupPoint.ID equals order.PickupPointID
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

        public ICommand SaveCommand { get; set; }
    }
}
