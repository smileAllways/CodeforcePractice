using System;

namespace CodeForce
{
    class _266A_StonesOnTheTable
    {
        static void Main()
        {
            int neighbor = 0;
            int inputSize = int.Parse(Console.ReadLine());
            string inputs = Console.ReadLine();
            char curruntStone = inputs[0];

            for(int i = 1; i < inputSize; i++)
            {
                if(curruntStone == inputs[i])
                {
                    neighbor++;
                }
                else
                {
                    curruntStone = inputs[i];
                }
            }

            Console.WriteLine(neighbor);
        }
    }
}