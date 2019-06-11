using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndLambdaExpressions.IAndIDelegate
{
    class InstantiatingAndInvokingADelegate
    {
        public delegate int PerformCalculation(int x, int y);
        public delegate int SecondDelegate(int[] numArray);
        public static void Main232()
        {

        //Instantiating a delegate

            //Using the new keyword
            PerformCalculation performCal = new PerformCalculation(Add);
            
            //Using delegate inference
            PerformCalculation performCalculation = Add;
            SecondDelegate secondDelegate = CountEvenNumbers;

        //Invoking a delegate

            //Invoking Asynchronously
            int[] numArray = { 42, 44, 45, 46, 47, 48, 49, 50 };
            secondDelegate.BeginInvoke(numArray,null, null);
            
            //Using the () operator
            performCal(40, 45);
            
            //Using the Invoke() method of the delegate class
            performCalculation.Invoke(40, 45);

            //End on the asynchronous invocation
            int sam = secondDelegate.EndInvoke(null);
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int CountEvenNumbers(int[] numArray)
        {
            List<int> evenNum = new List<int>();
            foreach (var num in  numArray)
            {
                if (num % 2 == 0)
                  evenNum.Add(num);
            }
            return evenNum.Count;
        }
    }
}