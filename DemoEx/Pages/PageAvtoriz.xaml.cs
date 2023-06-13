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
    /// Логика взаимодействия для PageAvtoriz.xaml
    /// </summary>
    public partial class PageAvtoriz : Page
    {
        public PageAvtoriz()
        {
            InitializeComponent();
        }
        // Для авторизации 
        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            if (TBlogin.Text != null && TBPassword.Text != null)
            {
                if (App.Context.User.Where(p => p.Login == TBlogin.Text && p.Password == TBPassword.Text).Count() == 1)
                {
                    // Запоминаем кто вошел и переходим к просмотру продуктов
                    App.userAvtoriz = App.Context.User.FirstOrDefault(p => p.Login == TBlogin.Text && p.Password == TBPassword.Text);
                    NavigationService.Navigate(new Pages.PageContent());
                }
                else
                    MessageBox.Show("Пользователь не найден", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
                MessageBox.Show("Заполните поля","Error", MessageBoxButton.OK,MessageBoxImage.Error);
        }
    }
}
