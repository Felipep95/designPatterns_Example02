using PadroesDeProjetoTrab_02.Discount_Methods;
using PadroesDeProjetoTrab_02.Interface;

namespace PadroesDeProjetoTrab_02
{
    class Discount
    {
        private string _Discount = "InCash";
        public IFactoryDiscount factory;

        public Discount()
        {
            if (_Discount.Equals("InCash"))
                factory = (IFactoryDiscount)new InCash();
            
            if (_Discount.Equals("Debit"))
                factory = (IFactoryDiscount)new Debit();
            
            if (_Discount.Equals("ParceledOut"))
                factory = (IFactoryDiscount)new ParceledOut();
        }
    }
}
