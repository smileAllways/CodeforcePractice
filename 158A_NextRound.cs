using System;

namespace CodeForce
{
    class _158A_NextRound
    {
        static void _158A()
        {
            int count = 0;
            int participantSize, standardInedx, minScore;
            string[] s = Console.ReadLine().Split(' ');

            participantSize = int.Parse(s[0]);
            standardInedx = int.Parse(s[1]) - 1;

            s = Console.ReadLine().Split(' ');

            if(int.Parse(s[standardInedx]) > 0)
            {
                minScore = int.Parse(s[standardInedx]);
            }
            else
            {
                minScore = 1;
            }

            for (int i = 0; i < participantSize; i++)
            {
                if(int.Parse(s[i]) >= minScore)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(count);
        }
    }
}