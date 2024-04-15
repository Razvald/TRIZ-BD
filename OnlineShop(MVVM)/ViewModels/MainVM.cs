using OnlineShop_MVVM_.Command;
using System.Windows.Input;

namespace OnlineShop_MVVM_.ViewModels
{
    public class MainVM : VMBase
    {
        private readonly VMStore _viewModelStore;
        private readonly EmployeeStore _employeeStore;
        public VMBase CurrentViewModel => _viewModelStore.CurrentViewModel;

        public ICommand NavigateCommand { get; }
        public ICommand LoginCommand { get; }
        public MainVM(VMStore viewModelStore, EmployeeStore employeeStore)
        {
            _viewModelStore = viewModelStore;
            _employeeStore = employeeStore;
            _viewModelStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
