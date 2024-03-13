using OnlineShop_MVVM_.Database.Entity;
using OnlineShop_MVVM_.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace OnlineShop_MVVM_.ViewModels
{
    public class ProductsVM : ViewModelBase
    {
        private readonly ProductsM _productsM;
        //public IEnumerable<Product> ProductsDataList { get; set; }
        public ObservableCollection<Product> ProductsDataList { get; set; } = new ObservableCollection<Product>();

        public ProductsVM()
        {
            _productsM = new ProductsM();
            //ProductsDataList = Product.GetProducts();

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

        //public IEnumerable<Product> Products
        //{
        //    get { return _productsM.Products; }
        //    set { _productsM.Products = value; OnPropertyChanged(nameof(Products)); }
        //}

        public ICommand Filter { get; set; }
        public ICommand PropertyChanged { get; set; }
    }
}
