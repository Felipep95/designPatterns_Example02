using PadroesDeProjetoTrab_02.Interface;
using System;


namespace PadroesDeProjetoTrab_02.Discount_Methods
{
    class ParceledOut : IDiscount
    {
        public void Discount(double discount)
        {
            discount += 0.0;
            Console.WriteLine($"Pagamento parcelado, desconto de: {discount * 100}%");
        }
    }
}
