using System;
using System.Diagnostics.Metrics;

namespace Numbers
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(CheckOfCorrect(Console.ReadLine()));
        }
        public static object CheckOfCorrect(string number)
        {
            int counter = 0;
            string listofnum = "0123456789-";
            foreach(char c in number)
            {
                if (!listofnum.Contains(c))
                    return "Не целочисленное!";
                for (int i = 0; i < 10; i++)
                {
                    if (listofnum[i] == c)
                    {
                        counter += i;
                    }
                }
            }
            return counter;
        }
    }
}