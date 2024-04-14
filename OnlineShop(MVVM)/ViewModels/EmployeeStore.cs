using OnlineShop_MVVM_.Database.Entity;

namespace OnlineShop_MVVM_.ViewModels
{
    class EmployeeStore
    {
        Employee _currentEmployee = new();
        public Employee CurrentEmployee
        {
            get { return _currentEmployee; }
            set
            {
                _currentEmployee = value;
                OnCurrentEmployeeChanged();
            }
        }

        public event Action CurrentEmployeeChanged;
        private void OnCurrentEmployeeChanged()
        {
            CurrentEmployeeChanged?.Invoke();
        }
    }
}
