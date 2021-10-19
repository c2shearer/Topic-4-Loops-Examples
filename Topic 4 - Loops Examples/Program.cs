using System;

namespace Topic_4_Loops_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 3;

            while (num >= 0) 
            {
                Console.WriteLine($"Number is {num}");
                // Post-fix decrement
                --num;
            }

            Console.WriteLine("End");

        }
    }
}
