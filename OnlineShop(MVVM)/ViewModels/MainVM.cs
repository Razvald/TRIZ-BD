using OnlineShop_MVVM_.Command;
using OnlineShop_MVVM_.Database.Entity;
using System.Windows.Input;

namespace OnlineShop_MVVM_.ViewModels
{
    public class MainVM : VMBase
    {
        private readonly VMStore _viewModelStore;
        private readonly EmployeeStore _employeeStore;
        public VMBase CurrentViewModel => _viewModelStore.CurrentViewModel;
        public Employee CurrentEmployee => _employeeStore.CurrentEmployee;

        public MainVM(VMStore viewModelStore, EmployeeStore employeeStore)
        {
            _viewModelStore = viewModelStore;
            _employeeStore = employeeStore;

            _viewModelStore.CurrentViewModel = new ProductsVM();
            _viewModelStore.CurrentViewModelChanged += OnCurrentViewModelChanged;

            _employeeStore.CurrentEmployee = new Employee();
            _employeeStore.CurrentEmployeeChanged += OnCurrentEmployeeChanged;


            ChangeViewModelCommand = new MainCommand(_viewModelStore, _employeeStore);
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
