using System;

namespace Numbers
{
    class Program
    {
        public static void Main()
        {
            IntOrFloat(Console.ReadLine());
        }
        private static void IntOrFloat(string num)
        {
            float lastnum = 0;
            while (num != "q")
            {            
                if (int.TryParse(num, out int number))
                {
                    Console.WriteLine((char)number);
                }
                else if (float.TryParse(num, out float floatnumber))
                {                    
                    if (floatnumber == lastnum)
                        break;
                    lastnum = float.Parse(num);
                }
                num = Console.ReadLine();
            }
        }
    }
}