using System;

namespace CodeForce
{
    class _71A_WayTooLongWord
    {
        void _71A()
        {
            int inputSize = int.Parse(Console.ReadLine());
            string[] output = new string[inputSize];

            for(int i = 0; i < inputSize; i++)
            {
                string temp = Console.ReadLine();

                if(temp.Length <= 10)
                {
                    output[i] = temp;
                }
                else
                {
                    output[i] = temp[0].ToString() + (temp.Length - 2).ToString() + temp[temp.Length - 1].ToString();
                }
            }

            foreach(string s in output)
            {
                Console.WriteLine(s);
            }
        }
    }
}
