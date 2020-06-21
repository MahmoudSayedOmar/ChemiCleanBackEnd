using System;
using System.Collections.Generic;
using System.Text;

namespace CROSSWORKERS.CHEMICLEAN.Utilities.DTOs
{
    public class ProductDto
    {
        public string ProductName { get; set; }
        public string SupplierName { get; set; }

        public Boolean IsAvailable { get; set; }

        public bool IsUpdatedInLastThreeDays { get; set; }

    }
}