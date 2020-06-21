using System;
using System.Collections.Generic;
using System.Text;

namespace CROSSWORKERS.CHEMICLEAN.Domain.Models
{
    public partial class Product
    {
        public string ProductName { get; set; }
        public string SupplierName { get; set; }
        public string Url { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public partial class Product : Entity<int>
    {
        public Boolean IsAvailable { get; set; }
        public string SafetyDataSheetPath { get; set; }
        public DateTime LastUpdate { get; set; }

    }
}
