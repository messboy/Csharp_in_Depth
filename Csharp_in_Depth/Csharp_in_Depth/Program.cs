using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_in_Depth
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = Product.GetSampleProducts();
            //C#2.0 使用委派取代額外實作IComparer 類別
            products.Sort(delegate(Product  x, Product y) { return x.Name.CompareTo(y.Name); });
            Print(products);

            //C#3.0 使用Lambda 進行排序
            products.Sort((x, y) => y.Name.CompareTo(x.Name));
            Print(products);

            //C#3.0 使用Lambda 擴展方法
            foreach (Product product in products.OrderBy(p => p.Name))
            {
                Console.WriteLine(product);
            }


        }

        private static void Print(List<Product> products)
        {
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine();
        }

    }

    
}
