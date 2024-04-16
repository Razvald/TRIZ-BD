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
                switch (viewModelName)
                {
                    case "LoginVM":
                        _viewModelStore.CurrentViewModel = new LoginVM(_viewModelStore, _employeeStore);
                        break;
                    case "PickupEmployeeVM":
                        _viewModelStore.CurrentViewModel = new PickupEmployeeVM();
                        break;
                    case "ProductsVM":
                        _viewModelStore.CurrentViewModel = new ProductsVM();
                        break;
                    case "StatisticsVM":
                        _viewModelStore.CurrentViewModel = new StatisticsVM();
                        break;
                    default:
                        throw new ArgumentException("Invalid ViewModel name");
                }
            }
            else
            {
                throw new ArgumentException("Invalid parameter type");
            }
        }
    }
}
