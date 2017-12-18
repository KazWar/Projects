using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2.Model
{
    public class calculations
    {
        public int sumSquares(int n)
        {
            if (n == 0)
                return 1;

            Math.Pow(n, 2);

            return sumSquares(n - 1);
        }
    }
}
