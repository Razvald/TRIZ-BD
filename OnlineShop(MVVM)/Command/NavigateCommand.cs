using OnlineShop_MVVM_.ViewModels;

namespace OnlineShop_MVVM_.Command
{
    class NavigateCommand : CommandBase
    {
        private readonly VMStore _viewModelStore;
        private readonly EmployeeStore _employeeStore;
        private readonly Func<VMStore, EmployeeStore, VMBase> _createViewModel;

        public NavigateCommand(VMStore viewModelStore, EmployeeStore employeeStore, Func<VMStore, EmployeeStore, VMBase> createViewModel)
        {
            _viewModelStore = viewModelStore;
            _employeeStore = employeeStore;
            _createViewModel = createViewModel;
        }

        public override void Execute(object parameter)
        {
            _viewModelStore.CurrentViewModel = _createViewModel(_viewModelStore, _employeeStore);
        }
    }
}
