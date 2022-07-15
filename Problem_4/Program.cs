//მოცემულია String რომელიც შედგება „(„ და „)“ ელემენტებისგან. დაწერეთ ფუნქცია რომელიც
//აბრუნებს ფრჩხილები არის თუ არა მათემატიკურად სწორად დასმული.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    class Program
    {
        static public void Main()
        {
            Console.WriteLine("Shemoitanet aso-nishanta mimdevroba");
            string sequence = Console.ReadLine() ?? String.Empty;
            bool result = IsProperly(sequence);

            if (result) Console.WriteLine("Swori mimdevrobaa");
            else Console.WriteLine("Araswori mimdevrobaa");
            Console.ReadKey();
        }

        private static bool IsProperly(string sequence)
        {
            int openBracketsCount = 0;
            int closeBracketscount = 0;
            sequence.ToCharArray();

            foreach (char character in sequence)
            {
                switch (character)
                {
                    case '(':
                        openBracketsCount++;
                        break;

                    case ')':
                        closeBracketscount++;
                        break;
                    default:
                        break;
                }
            }

            if (openBracketsCount == closeBracketscount)
                return true;
            else
                return false;
        }
    }
}
