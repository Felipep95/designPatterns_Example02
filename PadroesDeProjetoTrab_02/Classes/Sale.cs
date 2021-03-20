using PadroesDeProjetoTrab_02.Classes;
using PadroesDeProjetoTrab_02.Discount_Methods;
using PadroesDeProjetoTrab_02.Interface;
using System.Collections.Generic;

namespace PadroesDeProjetoTrab_02
{
    class Sale
    {
        public List<Product> products = new List<Product>();
        private string _Discount = "InCash";
        public IFactoryDiscount factory;

        Debit debit = new Debit();
        InCash inCash = new InCash();
        ParceledOut parceledOut = new ParceledOut();


        public void AddDiscount ()
        {
            if (_Discount.Equals("InCash"))
                factory = (IFactoryDiscount)new InCash();

            if (_Discount.Equals("Debit"))
                factory = (IFactoryDiscount)new Debit();

            if (_Discount.Equals("ParceledOut"))
                factory = (IFactoryDiscount)new ParceledOut();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public double getPrice(IFactoryDiscount factory)
        {
            double total = 0;
            
            foreach(var p in products)
            {
                total += p.Price;
            }

            if (_Discount.Equals("InCash"))
                inCash.Discount(total);

            if (_Discount.Equals("Debit"))
                debit.Discount(total);

            if (_Discount.Equals("ParceledOut"))
                parceledOut.Discount(total);

            return total;
        }
    }
}
