using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class MathOperations
    {
        private double Result { get; set; }

        public string SelectArithmaticMethod(int methodNumber, int number1, int number2)
        {
            switch (methodNumber)
            {
                case 1:
                    Addition(number1, number2);
                    break;
                case 2:
                    Substraction(number1, number2);
                    break;
                case 3:
                    Multiplication(number1, number2);
                    break;
                case 4:
                    Division(number1, number2);
                    break;
                default:
                    break;
            }

            return Result.ToString();
        }

        private void Addition(int number1, int number2)
        {
            Result = number1 + number2;
        }

        private void Substraction(int number1, int number2)
        {
            Result = number1 - number2;
        }

        private void Division(int number1, int number2)
        {
            Result = number1 / number2;
        }

        private void Multiplication(int number1, int number2)
        {
            Result = number1 * number2;
        }
    }
}
