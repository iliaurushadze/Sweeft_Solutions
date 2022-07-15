//მოცემულია მასივი, რომელიც შედგება მთელი რიცხვებისგან. დაწერეთ ფუნქცია რომელსაც გადაეცემა ეს მასივი და
//აბრუნებს მინიმალურ მთელ რიცხვს, რომელიც 0-ზე მეტია და ამ მასივში არ შედის.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static public void Main()
        {
            int result = NotContains(RandArrayGenerator());
            Console.WriteLine("Result: " + result);
            Console.ReadKey();
        }

        static int NotContains(int[] array)
        {
            Array.Sort(array);

            Console.WriteLine("Generated array: ");
            foreach (var item in array)
                Console.WriteLine(item);

            int result = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == result)
                {
                    result++;
                }
            }
            return result;
        }

        private static int[] RandArrayGenerator()
        {
            int Min = -20;
            int Max = 20;
            int[] randArray = new int[10];

            Random randNum = new Random();
            for (int i = 0; i < randArray.Length; i++)
            {
                randArray[i] = randNum.Next(Min, Max);
            }
            return randArray;
        }
    }
}
