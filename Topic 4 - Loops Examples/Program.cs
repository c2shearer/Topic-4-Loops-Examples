using System;

namespace Topic_4_Loops_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i <= 12)
            {
                int j = 1;
                while (j <= 12)
                {
                    Console.WriteLine($"{i} times {j} is: {i * j}");
                    j++;
                }
                i++;
            }

            Console.WriteLine("END");

        }
    }
}
