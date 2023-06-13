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
        public PageContent()
        {
            InitializeComponent();
        }
        // Для навигации к заказу
        private void BtnZakazView_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.PageZakaz());
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Тут должно быть что то еще но я не помню", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
