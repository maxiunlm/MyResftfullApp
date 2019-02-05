using System;
using System.Collections.Generic;
using System.Text;

namespace MyRestfullApp.Core.Currency
{
    public class PesoStrategy : ICurrencyStrategy
    {
        public decimal GetPrice()
        {
            return 0;
        }
    }
}
