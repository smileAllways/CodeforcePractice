using System;

namespace CodeForce
{
    class _263A_BeautifulMatrix
    {
        static void Main()
        {
            int row = 0;
            int column = 0;

            Input(out row, out column);

            Console.WriteLine(Math.Abs(row - 2) + Math.Abs(column - 2));
        }

        static void Input(out int row, out int column)
        {
            int x = -1, y = -1;
            for (int i = 0; i < 5; i++)
            {
                string[] inputRow = Console.ReadLine().Split(' ');

                for (int j = 0; j < 5; j++)
                {
                    if (inputRow[j] == "1")
                    {
                        x = i;
                        y = j;
                    }
                }
            }
            row = x; column = y;
        }
    }
}