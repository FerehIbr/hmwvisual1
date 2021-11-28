using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthorder = 3;
            Console.WriteLine(findseasonnamebymonthorder(monthorder));
        }
        static string findseasonnamebymonthorder(int month)
        {
            if (month > 12 || month < 1)
                return "bele bir ay yoxdur";

            if (month == 3 || month == 4 || month == 5)
            {
                return "yaz";
            }

            else if (month == 6 || month == 7 || month == 8)
            {
                return "yay";
            }

            else if (month == 9 || month == 10 || month == 11)
            {
                return "payiz";
            }
            else
            {
                return "qis";
            }
        }
    }
}
