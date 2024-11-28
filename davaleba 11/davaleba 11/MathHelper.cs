using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba_11
{
    internal class MathHelper
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("0 gayofa araa dashvbeuli.");
            }
            return (double)a / b;
        }
    }
}
