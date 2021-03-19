using System;
using PadroesDeProjetoTrab_02.Interface;

namespace PadroesDeProjetoTrab_02.Discount_Methods
{
    class InCash : IDiscount
    {
        
        public void Discount(double discount)
        {
            discount *=  0.20;
            Console.WriteLine($"Pagamento em a vista, desconto de: {discount * 100}%");
        }
    }
}
