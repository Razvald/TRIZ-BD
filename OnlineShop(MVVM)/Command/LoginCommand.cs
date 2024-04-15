using OnlineShop_MVVM_.Database.Entity;
using OnlineShop_MVVM_.ViewModels;
using System.Windows;

namespace OnlineShop_MVVM_.Command
{
    class LoginCommand : CommandBase
    {
        private VMStore _viewModelStore;
        private readonly EmployeeStore _employeeStore;
        private LoginVM _loginViewModel;

        public LoginCommand(VMStore viewModelStore, EmployeeStore employeeStore, LoginVM loginViewModel)
        {
            _viewModelStore = viewModelStore;
            _employeeStore = employeeStore;
            _loginViewModel = loginViewModel;
        }

        public override void Execute(object parameter)
        {
            try
            {
                Employee user = Employee.GetEmployees()
                    .FirstOrDefault(e => e.Login == _loginViewModel.Login && e.Password == _loginViewModel.Password);

                if (user != null)
                {
                    _employeeStore.CurrentEmployee = user;
                    if (_employeeStore.CurrentEmployee.Role == Role.Administrator)
                        _viewModelStore.CurrentViewModel = new StatisticsVM(_viewModelStore, _employeeStore);
                    else
                        _viewModelStore.CurrentViewModel = new ProductsVM(_viewModelStore, _employeeStore);
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
