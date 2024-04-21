using OnlineShop_MVVM_.Database;
using OnlineShop_MVVM_.Database.Entity;
using OnlineShop_MVVM_.ViewModels;
using System.Windows;

namespace OnlineShop_MVVM_.Command
{
    class LoginCommand : CommandBase
    {
        private readonly AppDbContext _dbContext;
        private readonly VMStore _viewModelStore;
        private readonly EmployeeStore _employeeStore;
        private readonly LoginVM _loginViewModel;

        public LoginCommand(VMStore viewModelStore, EmployeeStore employeeStore, LoginVM loginViewModel, AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _viewModelStore = viewModelStore;
            _employeeStore = employeeStore;
            _loginViewModel = loginViewModel;
        }

        public override void Execute(object parameter)
        {
            try
            {
                Employee user = _dbContext.Employees
                    .FirstOrDefault(e => e.Login == _loginViewModel.Login && e.Password == _loginViewModel.Password);

                if (user != null)
                {
                    _employeeStore.CurrentEmployee = user;
                    if (_employeeStore.CurrentEmployee.Role == _dbContext.Roles.FirstOrDefault(r => r.ID == 1))
                        _viewModelStore.CurrentViewModel = new StatisticsVM(_dbContext, _employeeStore);
                    else
                        _viewModelStore.CurrentViewModel = new ProductsVM(_dbContext, _employeeStore);
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
