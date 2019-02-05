using MyRestfullApp.Core.Excpetions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRestfullApp.Core.Currency
{
    public class CurrencyStrategyManager
    {
        public ICurrencyStrategy GetStrategy(StrategyType type)
        {
            switch(type)
            {
                case StrategyType.dolar:
                    return new DolarStrategy();
                case StrategyType.real:
                    return new RealStrategy();
                case StrategyType.peso:
                    return new PesoStrategy();
                default:
                    throw new ParameterException("Parameter value is wrong");
            }
        }
    }
}
