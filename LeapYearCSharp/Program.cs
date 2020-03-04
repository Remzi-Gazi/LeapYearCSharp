using System;

namespace LeapYearCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Enter year: ");
			int year = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(is_leap(year));
			Console.Read();
        }
		static bool is_leap(int year)
		{
			bool leap = false;

			if (year % 400 == 0)
				leap = true;
			else if (year % 100 == 0)
				leap = false;
			else if (year % 4 == 0)
				leap = true;

			return leap;
		}
	}
}
