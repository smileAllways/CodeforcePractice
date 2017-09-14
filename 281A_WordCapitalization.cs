using System;

namespace CodeForce
{
    class _281A_WordCapitalization
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char first = input[0];

            if (first >= 97 && first <= 122)
            {
                Console.Write((char)(first - 32));
            }
            else
            {
                Console.Write(first);
            }

            Console.WriteLine(input.Remove(0, 1));
        }
    }
}