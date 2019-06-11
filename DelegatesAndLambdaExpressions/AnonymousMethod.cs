using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndLambdaExpressions.AnonymousMethod
{
    public delegate int PerformCalculation(int x, int y);
    class AnonymousMethod
    {
        public static void Main1()
        {
            //PerformCalculation performCal = Add;
            //PerformCalculation performCalculation = delegate (int x, int y)
            //{
            //    return x + y;
            //};

            PerformCalculation performCalculate = (int x, int y) => { return x + y; };
            performCalculate += (x, y) =>
            {
                int result;
                Console.WriteLine($"The numbers are {x} and {y}");
                result = x * y;
                return result;
            };
        }

        //public static int Add(int x, int y)
        //{
        //    return x + y;
        //}
    }
}
