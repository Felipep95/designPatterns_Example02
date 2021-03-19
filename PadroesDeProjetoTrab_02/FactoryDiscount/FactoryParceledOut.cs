using PadroesDeProjetoTrab_02.Discount_Methods;
using PadroesDeProjetoTrab_02.Interface;

namespace PadroesDeProjetoTrab_02.FactoryDiscount
{
    class FactoryParceledOut : IFactoryDiscount
    {
        public IDiscount getDiscount()
        {
            return new ParceledOut();
        }
    }
}
