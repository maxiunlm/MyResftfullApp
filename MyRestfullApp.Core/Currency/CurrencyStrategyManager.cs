using MyRestfullApp.Core.Excpetions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRestfullApp.Core.Currency
{
    public class CurrencyStrategyManager
    {
        private const string wrongParameterMessage = "Parameter value is wrong";

        public StrategyType GetStrategyType(string currency)
        {
            currency = currency ?? string.Empty;
            StrategyType type;

            if (!Enum.TryParse<StrategyType>(currency.ToLower(), out type))
            {
                throw new ParameterException(wrongParameterMessage);
            }

            return type;
        }

        public ICurrencyStrategy GetStrategy(StrategyType type)
        {
            switch (type)
            {
                case StrategyType.dolar:
                    return new DolarStrategy();
                case StrategyType.real:
                    return new RealStrategy();
                case StrategyType.peso:
                    return new PesoStrategy();
                default:
                    throw new ParameterException(wrongParameterMessage);
            }
        }
    }
}
