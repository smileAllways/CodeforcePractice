using System;

namespace CodeForce
{
    class _122A_LuckyDivision
    {
        static void Main()
        {
            string sInput = Console.ReadLine();
            int iInput = int.Parse(sInput);

            // 문자열로서의 검사
            for(int i = 0; i < sInput.Length; i++)
            {
                // 검사도중 4 또는 7이 아니면 불합격
                if (sInput[i] != '4' && sInput[i] != '7')
                {
                    break;
                }
                // 끝까지 루프를 순회하면 합격
                if(i == sInput.Length - 1)
                {
                    Console.WriteLine("YES");
                    return;
                }
            }

            // 정수로서의 검사
            if(iInput % 4 == 0 || iInput % 7 == 0
                || iInput % 44 == 0 || iInput % 47 == 0
                || iInput % 74 == 0 || iInput % 77 == 0
                || iInput % 444 == 0 || iInput % 447 == 0
                || iInput % 474 == 0 || iInput % 477 == 0
                || iInput % 744 == 0 || iInput % 747 == 0
                || iInput % 774 == 0 || iInput % 777 == 0)
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