//გვაქვს 1,5,10,20 და 50 თეთრიანი მონეტები. დაწერეთ ფუნქცია, რომელსაც გადაეცემა თანხა (თეთრებში)
//და აბრუნებს მონეტების მინიმალურ რაოდენობას, რომლითაც შეგვიძლია ეს თანხა დავახურდაოთ.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("Shemoitanet tanxa tetrebshi: ");
			string input = Console.ReadLine() ?? String.Empty;
			int amount = Int32.Parse(input);
			Console.WriteLine("Monetebis minimaluri raodenoba tanxis dasaxurdaveblad aris: " + MinSplit(amount));
			Console.ReadKey();
		}

		static int MinSplit(int amount)
		{
			int[] dividers = { 50, 20, 10, 5, 1 };
			int count = 0;
			int division = 0;

			foreach (var divider in dividers)
			{
				division = amount / divider;
				amount = amount % divider;
				if (division >= 1)
				{
					count = count + division;
				}
			}

			return count;
		}
	}
}
