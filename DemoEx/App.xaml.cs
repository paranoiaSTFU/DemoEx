using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DemoEx
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static DB.DemoExEntities2 Context { get; } = new DB.DemoExEntities2();
        public static DB.User userAvtoriz = null;
    }
}
