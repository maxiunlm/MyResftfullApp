using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MyRestfullApp.Core.Currency
{
    public class RealStrategy : ICurrencyStrategy
    {
        public Price GetPrice()
        {
            throw new UnauthorizedAccessException(StrategyType.real.ToString());
        }
    }
}
