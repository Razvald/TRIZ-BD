using OnlineShop_MVVM_.ViewModels;

namespace OnlineShop_MVVM_.Command
{
    public class MainCommand : CommandBase
    {
        private readonly VMStore _viewModelStore;
        private readonly EmployeeStore _employeeStore;

        public MainCommand(VMStore viewModelStore, EmployeeStore employeeStore)
        {
            _viewModelStore = viewModelStore;
            _employeeStore = employeeStore;
        }

        public override void Execute(object parameter)
        {
            if (parameter is string viewModelName)
            {
                Func<VMStore, EmployeeStore, VMBase> createViewModel = viewModelName switch
                {
                    "LoginVM" => (vmStore, empStore) => new LoginVM(vmStore, empStore),
                    "PickupEmployeeVM" => (vmStore, empStore) => new PickupEmployeeVM(),
                    "ProductsVM" => (vmStore, empStore) => new ProductsVM(),
                    "StatisticsVM" => (vmStore, empStore) => new StatisticsVM(),
                    _ => throw new ArgumentException("Invalid ViewModel name"),
                };

                NavigateCommand navigateCommand = new(_viewModelStore, _employeeStore, createViewModel);
                navigateCommand.Execute(null);
            }
            else
            {
                throw new ArgumentException("Invalid parameter type");
            }
        }
    }
}
