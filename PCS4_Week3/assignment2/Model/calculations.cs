using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2.Model
{
    public class calculations
    {
        public double Result { get;  set; }
        public double sumSquares(int n)
        {
            if (n == -1)
            {
                return Result;
            }

            Result += Math.Pow(n, 2);

            return sumSquares((n - 1));
        }

        public double sum(int[] x,int n)
        {
            if (n == -1)
            {
                return Result;
            }

            Result += x[n];

            return sum(x, --n);
        }
    }
}
