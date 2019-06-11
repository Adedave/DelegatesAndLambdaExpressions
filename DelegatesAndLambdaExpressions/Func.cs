using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndLambdaExpressions
{
    class FuncClass
    {

            public static void Mai2n()
            {
                Func<int, int, int> func = Add;
                Action<int, int> action = AddMethodTwo;
                Predicate<int> predicate = CompareMethod;
            }
            public static int Add(int a, int b)
            {
                return a + b;
            }
            public static void AddMethodTwo(int a, int b)
            {
                Console.WriteLine(a + b);
            }
            public static bool CompareMethod(int a)
            {
                return a > 27;
            }
    }
}


