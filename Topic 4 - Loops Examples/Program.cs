using System;

namespace Topic_4_Loops_Examples
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = 1;
            int large = 0;

            while (input != 0)
            {
                input = Convert.ToInt32(Console.ReadLine());
                if (input % 2 == 0)
                {
                    Console.WriteLine("Positive Integer");
                    
                    if (input > large)
                    {
                        large = input;
                        Console.WriteLine("OK");
                    } else
                    {
                        Console.WriteLine("OK");
                    }
                }
                else
                {
                    Console.WriteLine("Negative Integer");
                }
            }
            Console.WriteLine($"\nZero has been entered\nLargest Number submitted was: {large}");
        }
    }
}
