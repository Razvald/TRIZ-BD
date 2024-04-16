using OnlineShop_MVVM_.Command;
using System.Windows.Input;

namespace OnlineShop_MVVM_.ViewModels
{
    public class MainVM : VMBase
    {
        private readonly VMStore _viewModelStore;
        private readonly EmployeeStore _employeeStore;
        public VMBase CurrentViewModel => _viewModelStore.CurrentViewModel;

        public MainVM(VMStore viewModelStore, EmployeeStore employeeStore)
        {
            _viewModelStore = viewModelStore;
            _employeeStore = employeeStore;

            _viewModelStore.CurrentViewModel = new ProductsVM();

            _viewModelStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
            
            ChangeViewModelCommand = new MainCommand(_viewModelStore, _employeeStore);
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }

        public ICommand ChangeViewModelCommand { get; }
    }
}
