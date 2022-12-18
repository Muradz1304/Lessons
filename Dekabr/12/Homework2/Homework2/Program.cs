using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Explicit Type Conversion 

            byte a = 200;
            short b = (short)a;

            short b1 = 20000;
            int i1 = (int)b1;

            int i2 = 20000000;
            long l1 = (long)i2;

            long l2 = 1000000000;
            float f1 = (float)l2;

            float f2 = 30.2f;
            double d1 = (double)f2;




        }
    }
}
