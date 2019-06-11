using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndLambdaExpressions.DelegatesWithEvents
{
    public delegate void OnFiveHandler(object sender, int num);
    
    //Event Publisher Class
    class SampleEvents
    {
        public event OnFiveHandler FiveEvent;

        public void OnFiveEvent(int num)
        {
            if (FiveEvent != null)
                FiveEvent(this, num);
        }
    }
    public class UsingEvents
    {
        static void Main3()
        {
            SampleEvents se = new SampleEvents();
            //First event Subscription
            se.FiveEvent += new OnFiveHandler(Callback);
            //Second Event Subscription
            se.FiveEvent += new OnFiveHandler(SecondEventSubscriber.CallbackTwo);

            int[] intArray = {4, 5, 6, 4, 11, 6, 4, 15, 6, 4, 12, 6};

            foreach (var num in intArray)
            {
                if (num % 5 == 0)
                {
                    Console.WriteLine($"Number is : {num}");
                    se.OnFiveEvent(num);
                }
            }
            Console.ReadLine();
        }
        public static void Callback(object sender, int num)
        {
            Console.WriteLine($"{num} is a multiple of 5");
        }
    }
    
    //Event Subscriber Class
    class SecondEventSubscriber
    {
        public static void CallbackTwo(object sender, int number)
        {
            int factor = number / 5;
            Console.Beep(500, 2500);
            Console.WriteLine($"{number} divide by 5 is: {factor}");
        }
    }
}

