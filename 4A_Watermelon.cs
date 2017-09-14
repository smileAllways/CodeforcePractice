using System;

namespace CodeForce
{
    class _4A_Watermelon
    {
        void _4A()
        {
            int input = int.Parse(Console.ReadLine());

            if(input == 2 || (input % 2) != 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
    }


}
