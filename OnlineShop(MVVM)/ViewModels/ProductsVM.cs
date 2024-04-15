using OnlineShop_MVVM_.Command;
using OnlineShop_MVVM_.Database.Entity;
using OnlineShop_MVVM_.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace OnlineShop_MVVM_.ViewModels
{
    public class ProductsVM : VMBase
    {
        private readonly VMStore _vmStore;
        private readonly EmployeeStore _epmStore;
        private readonly ProductsM _productsM;
        public ObservableCollection<Product> ProductsDataList { get; set; } = new ObservableCollection<Product>();

        public ProductsVM(VMStore vmStore, EmployeeStore empStore)
        {
            _vmStore = vmStore;
            _epmStore = empStore;
            _productsM = new ProductsM();

            prodList();
        }

        private void prodList()
        {
            var products = Product.GetProducts();

            foreach (var emp in products)
            {
                ProductsDataList.Add(emp);
            }
        }

        public string Search
        {
            get { return _productsM.Search; }
            set { _productsM.Search = value; OnPropertyChanged(nameof(Search)); }
        }

        public ICommand Filter { get; set; }
        public ICommand PropertyChanged { get; set; }
    }
}
