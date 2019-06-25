using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndLambdaExpressions
{
    class Program
    {
        public delegate int PerformCalculation(int x, int y);
        static void Main(string[] args)
        {
            Action<int, int> action = New;
            Func<int, int, string> func = Populate;
            Predicate<int> predicate = Compare;
            //Creates a new PerformCalculation type
            PerformCalculation performCalculation = new PerformCalculation(Add);
            PerformCalculation perform = Add;
            perform += Multiply;

            //add method to feedback to user 
            //add methods to store data in database, send Mail 
            performCalculation(40, 45);
            performCalculation.Invoke(40, 45);
            perform.BeginInvoke(40, 45, null, null);
            //feedback to the user synchronously
            // store data in database, send Mail  runs asynchronously on another thread
            int sam = perform.EndInvoke(null);
        }

        static void New(int a,int b)
        {
            Console.WriteLine(  a + b);
        }
        static bool Compare(int a)
        {
            return a > 3;
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static string Populate(int a, int b)
        {
            return $"a +b";
        }
        static int Multiply(int x, int y)
        { return x * y; }
    }
}
