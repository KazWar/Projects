using Assignment1.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class InputValidator
    {
        public double ValidateNumber(string text)
        {
            if (String.IsNullOrWhiteSpace(text))
                throw new MissingInputException();

            var value = 0.0;
            if (double.TryParse(text, out value))
                return value;
            else
                throw new InvalidInputException(text);
        }

    }
}
