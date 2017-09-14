using System;

namespace CodeForce
{
    class _58A_ChatRoom
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string target = "hello";
            int targetIndex = 0;

            foreach(var letter in input)
            {
                if(target[targetIndex] == letter)
                {
                    if(++targetIndex == 5)
                    {
                        Console.WriteLine("YES");
                        return;
                    }
                }
            }

            Console.WriteLine("NO");
        }
    }
}