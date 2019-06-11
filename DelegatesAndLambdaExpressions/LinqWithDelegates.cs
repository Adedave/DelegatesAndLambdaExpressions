using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndLambdaExpressions
{
    class LinqWithDelegates
    {
        delegate bool EvaluateCondition(string value);

        static void Main23(string[] args)
        {
            // Create a list of sci-fi shows.

            List<string> mostWanted = new List<string>
            {
            "Sade Quill", "Saheed Voyager", "Deep Star",
            "Battle Gallactica", "Doctor Depp", "Tony Stark",
            "Atlanta George", "Davies John", "Futura Macquel"
            };

            List<string> filteredList = FilterList(mostWanted, MyStartsWith);

            // Print each name in the filtered list to the console.
            foreach (string name in filteredList)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
        static bool MyStartsWith(string value)
        {
            return value.StartsWith("D");
        }
        static List<string> FilterList(List<string> list, EvaluateCondition evaluateCondition)
        {
            List<string> filteredList = new List<string>();

            foreach (string show in list)
                if (evaluateCondition(show))
                    filteredList.Add(show);

            return filteredList;
        }
    }
}
