//დაწერეთ ფუნქცია, რომელსაც გადაეცემა ტექსტი  და აბრუნებს პალინდრომია თუ არა.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shemoitanet teqsti: ");
            string text = Console.ReadLine() ?? String.Empty;
            bool result = sPalindrome(text);

            if (result) Console.WriteLine("Shemotanili teqsti aris: palindromi");
            else Console.WriteLine("Shemotanili teqsti ar aris: palindromi");
            Console.ReadKey();
        }

        static bool sPalindrome(string text)
        {
            char[] charArray = text.ToCharArray();
            char[] tempArray = charArray;
            Array.Reverse(tempArray);
            string reversedText = new string(tempArray);

            bool result = text.Equals(reversedText, StringComparison.OrdinalIgnoreCase);

            if (result)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
