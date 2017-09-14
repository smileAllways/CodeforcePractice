using System;

namespace CodeForce
{
    class _160A_Twins
    {
        static int[] nums;

        static void Main()
        {
            int inputSize = int.Parse(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split(' ');
            nums = new int[inputSize];
            
            for(int i = 0; i < inputSize; i++)
            {
                nums[i] = int.Parse(inputs[i]);
            }
            Array.Sort(nums);

            for(int i = 1; i <= inputSize; i++)
            {
                if(sum(i))
                {
                    Console.WriteLine(i);
                    return;
                }
            }
        }

        static bool sum(int myCoinsNum)
        {
            int mySum = 0;
            int twinsSum = 0;

            for(int i = 0; i < nums.Length - myCoinsNum; i++)
            {
                twinsSum += nums[i];
            }
            for(int i = 0; i < myCoinsNum; i++)
            {
                mySum += nums[nums.Length - 1 - i];
            }

            if(twinsSum < mySum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}