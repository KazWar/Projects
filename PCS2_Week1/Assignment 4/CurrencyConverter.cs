using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    static public class CurrencyConverter
    {
        static public decimal ConvertTo(decimal value1, decimal exchangeValue)
        {
            var result = value1 * exchangeValue;
            return result;
        }
        static public decimal ConvertFrom(decimal value1, decimal exchangeValue)
        {
            var result = value1 / exchangeValue;
            return result;
        }

    }
}
