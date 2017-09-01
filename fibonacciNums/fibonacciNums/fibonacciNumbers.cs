using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacciNums
{
    public static class fiboNumbers
    {
        public static int Calc (int num)
        {
            int a = 1, b = 0, temp;
            while(num >= -1)
            {
                temp = a;
                a = a + b;
                b = temp;
                num--;
            }
            return b;
        }
    }
}
