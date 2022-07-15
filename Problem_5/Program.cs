// გვაქვს n სართულიანი კიბე, ერთ მოქმედებაში შეგვიძლია ავიდეთ 1 ან 2 საფეხურით. დაწერეთ ფუნქცია რომელიც
// დაითვლის n სართულზე ასვლის ვარიანტების რაოდენობას.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5
{
    class Program
    {
		static public void Main()
		{
			Console.WriteLine("Shemoitanet safexurebis raodenoba: ");
			int stairCount = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Variantebis raodenobaa = " + CountVariants(stairCount));
			Console.ReadKey();
		}

		static int CountVariants(int stairCount)
		{
			return Fib(stairCount + 1);
		}

		static int Fib(int n)
		{
			if (n <= 1)
			{
				return n;
			}
			else
			{
				return Fib(n - 1) + Fib(n - 2);
			}
		}
	}
}
