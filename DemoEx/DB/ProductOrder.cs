//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoEx.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductOrder
    {
        public int IDProductCount { get; set; }
        public int IDOrder { get; set; }
        public Nullable<int> ProductCount { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
