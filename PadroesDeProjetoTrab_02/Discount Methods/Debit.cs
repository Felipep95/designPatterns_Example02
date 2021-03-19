using PadroesDeProjetoTrab_02.Interface;
using System;


namespace PadroesDeProjetoTrab_02.Discount_Methods
{
    class Debit : IDiscount
    {
        public void Discount(double discount)
        {
            discount *= 0.15;
            Console.WriteLine($"Pagamento por débito, desconto de: {discount * 100}%");
        }
    }
}
