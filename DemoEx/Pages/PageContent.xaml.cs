using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoEx.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageContent.xaml
    /// </summary>
    public partial class PageContent : Page
    {
        public Random random = new Random();
        public PageContent()
        {
            InitializeComponent();
            LVproduct.ItemsSource = App.Context.Product.ToList();
            BtnZakazVisible();
        }
        // Для навигации к заказу
        private void BtnZakazView_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.PageZakaz());
        }
        // Для какой то еще кнопки
        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Тут должно быть что то еще но я не помню", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        // Для скрытия кнопки с заказами
        private void BtnZakazVisible()
        {
            if (App.Context.Order.Where(p => p.User.ID == App.userAvtoriz.ID).Count() == 0)
            {
                BtnZakazView.Visibility = Visibility.Hidden; 
            }
            else
            {
                BtnZakazView.Visibility = Visibility.Visible;
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            var SelectedProduct = (sender as Button).DataContext as DB.Product;
            if (App.Context.Order.Where(p => p.User.ID == App.userAvtoriz.ID).Count() == 0) 
            {
                var NewOrder = new DB.Order();
                NewOrder.Code = random.Next(100, 999);
                //if(SelectedProduct)
                //NewOrder.DateEnd
            }
            
            BtnZakazVisible();
        }
    }
}
