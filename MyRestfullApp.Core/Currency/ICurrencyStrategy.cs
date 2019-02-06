using System;
using System.Collections.Generic;
using System.Text;

namespace MyRestfullApp.Core.Currency
{
    public interface ICurrencyStrategy
    {
        Price GetPrice();
    }
}
