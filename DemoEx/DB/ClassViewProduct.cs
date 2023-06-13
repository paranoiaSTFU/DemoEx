using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEx.DB
{
    public partial class Product
    {
        // Для вывода продуктов
        public string NameView { get { return $"Название товара: {Name}"; } }
        public string DiscriptionView { get { return $"Описание товара: \n{Discription}"; } }
        public string PriceView { get { return $"Цена товара: {Price}"; } }
        public string SaleView { get { return $"Скидка на товар: {Sale}%"; } }
        public string ManufactureView { get { return $"Производитель товара: {ManufactureList.Name}"; } }
        public string PhotoView { get { return $"{Photo}"; } }

        // Для стилей
         public string NullOrder
        {
            get
            {
                if (App.Context.Order.Where(p => p.User.ID == App.userAvtoriz.ID).Count() == 0)
                {
                    return "Hidden";
                }
                else
                {
                    return "Visible";
                }
            }
        }
    }
}
