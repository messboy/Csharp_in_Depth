using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_in_Depth
{
    public class Product
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        private Product()
        {
        }

        public static List<Product> GetSampleProducts()
        {
            return new List<Product>
            {
                new Product {Name = "west side", Price = 9.99m},
                new Product {Name = "assaa side", Price = 13.99m},
                new Product {Name = "bbbbb side", Price = 14.99m},
                new Product {Name = "sweeney side", Price = 19.99m},
            };
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Name, Price);
        }

    }
}
