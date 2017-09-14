using System;

namespace CodeForce
{
    class _158B_Taxi
    {
        static void Main()
        {
            int groupSize = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int taxiCount = 0;
            int memberThree = 0;
            int memberTwo = 0;
            int memberOne = 0;
            
            for(int i = 0; i < groupSize; i++)
            {
                // 4인은 무조건 1대 차지
                if(input[i].Equals("4"))
                {
                    taxiCount++;
                }
                // 3인도 무조건 1대 차지, 다만 추후에 1명 추가 가능
                else if (input[i].Equals("3"))
                {
                    memberThree++;
                    taxiCount++;
                }
                // 2인은 2그룹이 1대 차지, 1그룹이 남으면 추후에 1인 그룹 2그룹 추가 가능
                // 값의 범위는 0 ~ 1
                else if (input[i].Equals("2"))
                {
                    memberTwo++;
                    if (memberTwo == 2)
                    {
                        memberTwo = 0;
                        continue;
                    }
                    taxiCount++;
                }
                else
                {
                    memberOne++;
                }
            }

            // 1명 그룹을 3명 그룹에 넣는 작업
            if(memberOne <= memberThree)
            {
                // 1명 그룹이 적으면 그대로 종료
                // 왜냐하면, 3명 그룹의 택시에 각각 합석하면 된다.
                Console.WriteLine(taxiCount);
                return;
            }
            else
            {
                // 3인 그룹에 가능한 합석
                memberOne -= memberThree;
            }

            // 1명 그룹을 2명 그룹에 넣는 작업
            // 2명 그룹 1개
            if(memberTwo == 1)
            {
                if(memberOne <= 2)
                {
                    Console.WriteLine(taxiCount);
                    return;
                }
                else
                {
                    memberOne -= 2;
                    taxiCount += memberOne / 4;
                    if((memberOne % 4) != 0)
                    {
                        taxiCount++;
                    }
                }
            }
            // 2명 그룹 0개
            else
            {
                taxiCount += memberOne / 4;
                if ((memberOne % 4) != 0)
                {
                    taxiCount++;
                }
            }

            Console.WriteLine(taxiCount);
        }
    }
}