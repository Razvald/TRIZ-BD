using OnlineShop_MVVM_.ViewModels;
using OnlineShop_MVVM_.Views;
using System.Windows;

namespace OnlineShop_MVVM_
{
    public partial class App : Application
    {
        private readonly ViewModelStore _viewModelStore;

        public App()
        {
            _viewModelStore = new ViewModelStore();
            _viewModelStore.CurrentViewModel = new MainViewModel(_viewModelStore);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_viewModelStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
