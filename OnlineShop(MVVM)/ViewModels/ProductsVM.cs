using OnlineShop_MVVM_.Command;
using OnlineShop_MVVM_.Database.Entity;
using OnlineShop_MVVM_.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace OnlineShop_MVVM_.ViewModels
{
    public class ProductsVM : VMBase
    {
        private readonly ProductsM _productsM;
        public ObservableCollection<Product> ProductsDataList { get; set; } = new ObservableCollection<Product>();
        public ObservableCollection<Category> Categories { get; set; } = new ObservableCollection<Category>();
        private Category _selectedCategory;
        private ObservableCollection<Product> _allProducts;

        public ProductsVM()
        {
            _productsM = new ProductsM();
            _allProducts = new ObservableCollection<Product>(Product.GetProducts());
            
            UpdateFilteredProducts();
            LoadCategories();

            SaveCommand = new SaveCommand();

            PropertyChanged += ProductsVM_PropertyChanged;
        }

        private void LoadCategories()
        {
            Categories.Clear();

            foreach (Category category in Enum.GetValues(typeof(Category)))
            {
                Categories.Add(category);
            }
        }

        private void ProductsVM_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Search))
            {
                UpdateFilteredProducts();
            }
            else if (e.PropertyName == nameof(SelectedCategory))
            {
                UpdateCategoryFilter();
            }
        }

        private void UpdateFilteredProducts()
        {
            ProductsDataList.Clear();

            foreach (var product in _allProducts)
            {
                if (MatchesSearch(product) && (product.Category == _selectedCategory || _selectedCategory == Category.All))
                {
                    ProductsDataList.Add(product);
                }
            }
        }

        private void UpdateCategoryFilter()
        {
            ProductsDataList.Clear();

            foreach (var product in _allProducts)
            {
                if (MatchesSearch(product) && (product.Category == _selectedCategory || _selectedCategory == Category.All))
                {
                    ProductsDataList.Add(product);
                }
            }
        }

        private bool MatchesSearch(Product product)
        {
            return string.IsNullOrEmpty(Search) || product.Title.ToLower().Contains(Search.ToLower());
        }

        public string Search
        {
            get { return _productsM.Search; }
            set { _productsM.Search = value; OnPropertyChanged(nameof(Search)); }
        }

        public Category SelectedCategory
        {
            get { return _selectedCategory; }
            set { _selectedCategory = value; OnPropertyChanged(nameof(SelectedCategory)); UpdateCategoryFilter(); }
        }

        public ICommand SaveCommand { get; set; }
    }
}
