using System;
using System.Collections.Generic;
using System.Text;

namespace MyRestfullApp.Core.Currency
{
    public class PesoStrategy : ICurrencyStrategy
    {
        public Price GetPrice()
        {
            throw new UnauthorizedAccessException(StrategyType.peso.ToString());
        }
    }
}
