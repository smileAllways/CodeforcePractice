using System;

namespace CodeForce
{
    class _116A_Tram
    {
        static void Main()
        {
            int minCapacity = 0;        // 구하고자하는 값
            int capacity = 0;
            int inputSize = int.Parse(Console.ReadLine());
            string[] inputs;

            {
                inputs = Console.ReadLine().Split(' ');
                capacity = int.Parse(inputs[1]);
                minCapacity = capacity;
            }
            for(int i = 1; i < inputSize; i++)
            {
                inputs = Console.ReadLine().Split(' ');

                capacity = capacity - int.Parse(inputs[0]) + int.Parse(inputs[1]);

                if (capacity > minCapacity)
                {
                    minCapacity = capacity;
                }
            }

            Console.WriteLine(minCapacity);
        }
    }
}