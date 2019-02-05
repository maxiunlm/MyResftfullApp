using System;
using System.Collections.Generic;
using System.Text;

namespace MyRestfullApp.Core.Currency
{
    public class RealStrategy : ICurrencyStrategy
    {
        public decimal GetPrice()
        {
            return 0;
        }
    }
}
