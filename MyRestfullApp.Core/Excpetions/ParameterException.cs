using System;
using System.Collections.Generic;
using System.Text;

namespace MyRestfullApp.Core.Excpetions
{
    public class ParameterException : Exception
    {
        public ParameterException(string message) : base(message)
        {
        }
    }
}
