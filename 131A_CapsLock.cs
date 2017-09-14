using System;

namespace CodeForce
{
    class _131A_CapsLock
    {
        static void Main()
        {
            string input = Console.ReadLine();

            // 첫번째가 대문자
            if(input[0] >= 'A' && input[0] <= 'Z')
            {
                // 이후 소문자가 나오면 그대로 출력
                for(int i = 1; i < input.Length; i++)
                {
                    if (input[i] >= 'a' && input[i] <= 'z')
                    {
                        Console.WriteLine(input);
                        return;
                    }
                }
                // 모두 대문자일경우
                Console.WriteLine(input.ToLower());
            }
            // 첫번째가 소문자
            else
            {
                // 이후 소문자가 나오면 그대로 출력
                for (int i = 1; i < input.Length; i++)
                {
                    if (input[i] >= 'a' && input[i] <= 'z')
                    {
                        Console.WriteLine(input);
                        return;
                    }
                }
                // 모두 대문자일경우
                Console.WriteLine("{0}{1}", Char.ToUpper(input[0]), input.Remove(0, 1).ToLower());
            }
        }
    }
}