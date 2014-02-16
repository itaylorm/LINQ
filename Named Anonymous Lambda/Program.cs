using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Named_Anonymous_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("A simple example without a lambda");

            int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var oddNumbers = Common.FilterArrayOfInts(numbers, Common.IsOdd);

            foreach(var i in oddNumbers)
                Console.WriteLine(i);

            Console.ReadLine();

            Console.WriteLine("The same logic only this uses an anonymous method");

            oddNumbers = Common.FilterArrayOfInts(numbers, delegate(int i) { return ((i & 1) == 1); });

            foreach (var i in oddNumbers)
                Console.WriteLine(i);

            Console.ReadLine();

            Console.WriteLine("The same logic as a lambda expression");


            oddNumbers = Common.FilterArrayOfInts(numbers, i => ((i & 1) == 1));
            foreach (var i in oddNumbers)
                Console.WriteLine(i);

            Console.ReadLine();

        }
    }
}
