using System;
using System.Linq;

namespace CodeForce
{
    class _133A_HQ9_
    {
        static void Main()
        {
            string input = Console.ReadLine();

            if(input.Contains('H') 
                || input.Contains('Q')
                || input.Contains('9'))
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