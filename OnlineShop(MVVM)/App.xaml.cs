using OnlineShop_MVVM_.Command;
using OnlineShop_MVVM_.Database;
using OnlineShop_MVVM_.ViewModels;
using OnlineShop_MVVM_.Views;
using System.Windows;

namespace OnlineShop_MVVM_
{
    public partial class App : Application
    {
        private readonly AppDbContext _context;
        private readonly VMStore _viewModelStore;
        private readonly EmployeeStore _employeeStore;

        public App()
        {
            _context = new AppDbContext();
            _viewModelStore = new VMStore();
            _employeeStore = new EmployeeStore();

            _viewModelStore.CurrentViewModel = new MainVM(_viewModelStore, _employeeStore, _context);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainV()
            {
                DataContext = new MainVM(_viewModelStore, _employeeStore, _context)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
