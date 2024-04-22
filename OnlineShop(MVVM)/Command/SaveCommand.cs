using OnlineShop_MVVM_.Database;
using OnlineShop_MVVM_.Database.Entity;
using System.Collections.ObjectModel;
using System.Windows;

namespace OnlineShop_MVVM_.Command
{
    public class SaveCommand : CommandBase
    {
        private readonly AppDbContext _context;
        public SaveCommand(AppDbContext dbContext)
        { 
            _context = dbContext;
        }

        public override void Execute(object parameter)
        {
            try
            {
                _context.SaveChanges();
                MessageBox.Show("Сохранение успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex?.InnerException?.Message);
            }
        }
    }
}
