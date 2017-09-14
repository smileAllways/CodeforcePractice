using System;

namespace CodeForce
{
    class _339A_HelpfulMaths
    {
        static void Main()
        {
            string[] output = Console.ReadLine().Split('+');
            Array.Sort(output);
            
            for(int i = 0; i < output.Length; i++)
            {
                if(i == 0)
                {
                    Console.Write(output[i]);
                }
                else
                {
                    Console.Write("+{0}", output[i]);
                }
            }
        }
    }
}