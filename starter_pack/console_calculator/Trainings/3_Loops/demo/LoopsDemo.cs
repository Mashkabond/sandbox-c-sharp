using System;

namespace loops
{
    internal class LoopsDemo
    {
        static void Main(string[] args)
        {
            // Show numbers from 0 to 4
            int counter = 0;
            while (counter < 5)
            {
                Console.WriteLine(counter);
                counter++;
            }

            // Show numbers from 0 to 4
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            // Show all even numbers from 0 to 4
            for (int i = 0; i < 5; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }

            // Show all even numbers from 0 to 4
            for (int i = 0; i < 5; i++)
            {
                if (i % 2 != 0) continue;
                Console.WriteLine(i);
            }

            // Ask to enter number and while user won't enter number greater then 0, keep asking
            while (true) 
            {
                string input = Console.ReadLine();
                if (int.Parse(input) > 0) break;
            }

            // Ask to enter number and while user won't enter number greater then 0, keep asking
            string text;
            do
            {
                text = Console.ReadLine();
            } while (int.Parse(text) <= 0);
        }
    }
}
