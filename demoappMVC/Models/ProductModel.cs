using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace demoappMVC.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public  DateTime PurchaseDate { get; set; }
    }
}