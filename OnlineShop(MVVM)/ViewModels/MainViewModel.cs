namespace OnlineShop_MVVM_.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly ViewModelStore _viewModelStore;

        public ViewModelBase CurrentViewModel => _viewModelStore.CurrentViewModel;

        public MainViewModel(ViewModelStore viewModelStore)
        {
            _viewModelStore = viewModelStore;
            _viewModelStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
