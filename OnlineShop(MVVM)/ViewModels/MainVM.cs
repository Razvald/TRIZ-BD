using OnlineShop_MVVM_.Command;
using OnlineShop_MVVM_.Database;
using OnlineShop_MVVM_.Database.Entity;
using System.Windows.Input;

namespace OnlineShop_MVVM_.ViewModels
{
    public class MainVM : VMBase
    {
        private readonly AppDbContext _dbContext;
        private readonly VMStore _viewModelStore;
        private readonly EmployeeStore _employeeStore;
        public VMBase CurrentViewModel => _viewModelStore.CurrentViewModel;
        public Employee CurrentEmployee
        {
            get
            {
                Employee employee = _employeeStore.CurrentEmployee;
                if (employee != null)
                {
                    // При получении текущего сотрудника из хранилища, также загружаем связанную с ним роль
                    employee.Role = _dbContext.Roles.FirstOrDefault(r => r.ID == employee.RoleID);
                }
                return employee;
            }
        }

        public MainVM(VMStore viewModelStore, EmployeeStore employeeStore, AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _viewModelStore = viewModelStore;
            _employeeStore = employeeStore;

            _viewModelStore.CurrentViewModel = new ProductsVM(_dbContext, _employeeStore);
            _viewModelStore.CurrentViewModelChanged += OnCurrentViewModelChanged;

            _employeeStore.CurrentEmployee = new Employee();
            _employeeStore.CurrentEmployeeChanged += OnCurrentEmployeeChanged;

            ChangeViewModelCommand = new MainCommand(_viewModelStore, _employeeStore, _dbContext);
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }

        private void OnCurrentEmployeeChanged()
        {
            OnPropertyChanged(nameof(CurrentEmployee));
        }

        public ICommand ChangeViewModelCommand { get; }
    }
}
