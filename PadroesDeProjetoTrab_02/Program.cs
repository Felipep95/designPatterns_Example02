using PadroesDeProjetoTrab_02.Classes;
using System.Collections.Generic;

namespace PadroesDeProjetoTrab_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale sale = new Sale();

            List<Product> products = new List<Product>();

            var p1 = new Product(1, "Notebook", 3000);
            var p2 = new Product(1, "Iphone", 4000);

            //products.Add(new Product (1, "Notebook", 2500));
            //products.Add(new Product (2, "Iphone", 3000));

            sale.AddProduct(p1);
            sale.AddProduct(p2);

            sale.AddDiscount();
        }
    }
}

 



