using OnlineShop_MVVM_.Command;
using OnlineShop_MVVM_.Database;
using OnlineShop_MVVM_.Models;
using System.Windows.Input;

namespace OnlineShop_MVVM_.ViewModels
{
    public class LoginVM : VMBase
    {
        public LoginM _loginM;
        public LoginVM(VMStore viewModelStore, EmployeeStore employeeStore, AppDbContext dbContext)
        { 
            _loginM = new LoginM();
            LoginCommand = new LoginCommand(viewModelStore, employeeStore, this, dbContext);
        }

        public string Login
        {
            get { return _loginM.LoginEmail; }
            set
            {
                _loginM.LoginEmail = value;
                OnPropertyChanged(nameof(Login));
            }
        }

        public string Password
        {
            get { return _loginM.Password; }
            set
            {
                _loginM.Password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public ICommand LoginCommand { get; set; }
    }
}
