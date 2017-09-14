using System;

namespace CodeForce
{
    class _96A_Football
    {
        static void Main()
        {
            string input = Console.ReadLine();

            if (input.Contains("0000000") || input.Contains("1111111"))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}