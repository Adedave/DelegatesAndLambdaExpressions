using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndLambdaExpressions.MulticastDelegate
{
    public class MulticastDelegate
    {
       public delegate int PerformCalculation(int x, int y);
        public static void Main()
        {
            PerformCalculation performCalculation = new PerformCalculation(Add);
            PerformCalculation performCal = Multiply;
            performCalculation += Multiply;
            //performCalculation += performCal;

            int val = performCalculation(40, 45); //returns 1800

            performCalculation -= Multiply;
            int result = performCalculation(40, 45); //returns 95
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Multiplied(int a, int b)
        {
            return a * b;
        }   
    }
}
