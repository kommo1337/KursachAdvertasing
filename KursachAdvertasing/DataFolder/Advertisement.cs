//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KursachAdvertasing.DataFolder
{
    using System;
    using System.Collections.Generic;
    
    public partial class Advertisement
    {
        public int IdAdvertisement { get; set; }
        public string AdvertisementName { get; set; }
        public string AdvertisementPrice { get; set; }
        public string AdvertisementPlace { get; set; }
        public System.DateTime AdvertisementDate { get; set; }
        public Nullable<int> IdCustomer { get; set; }
    
        public virtual Сustomer Сustomer { get; set; }
    }
}
