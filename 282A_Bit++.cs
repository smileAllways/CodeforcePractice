using System;

namespace CodeForce
{
    class _282A_Bit__
    {
        static void Main()
        {
            int inputSize = int.Parse(Console.ReadLine());
            int X = 0;

            for(int i = 0; i < inputSize; i++)
            {
                if (Console.ReadLine().Contains("++"))
                {
                    X++;
                }
                else
                {
                    X--;
                }
            }

            Console.WriteLine(X);
        }
    }
}
