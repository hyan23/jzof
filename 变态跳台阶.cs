// 变态跳台阶.cs
// 作者: hyan23
// 2020.05.08
// https://www.nowcoder.com/practice/22243d016f6b47f2a6928b4313c85387?tpId=13&tqId=11162&rp=1&ru=/ta/coding-interviews&qru=/ta/coding-interviews/question-ranking

// 运行时间：30ms
// 占用内存：3276k

using System;

namespace csharp
{
    public class Program
    {
        public static void Main()
        {
            new Program().Test();
        }

        public void Test()
        {
        }

        public int jumpFloorII(int number)
        {
            /*
            int[] dp = new int[Math.Max(3, number + 1)];
            dp[1] = 1;
            dp[2] = 2;
            for (int i = 3; i <= number; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    dp[i] += dp[j];
                }
                dp[i] += 1;
            }
            return dp[number];
            */
            return 1 << (number - 1);
        }
    }
}
