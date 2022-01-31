using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF14
{
    public enum ProductTypes
    {
        Food,
        Toy,
        Electronics
    }
     public class Product
    {
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Image { get; set; }
        public ProductTypes ProductType { get; set; }
    }
}
