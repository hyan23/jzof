// 斐波那契数列.cs
// 作者: hyan23
// 2020.05.08
// https://www.nowcoder.com/practice/c6c7742f5ba7442aada113136ddea0c3?tpId=13&tqId=11160&tPage=1&rp=1&ru=%2Fta%2Fcoding-interviews&qru=%2Fta%2Fcoding-interviews%2Fquestion-ranking

// 运行时间：33ms
// 占用内存：3520k

using System.Collections.Generic;

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

        Dictionary<int, int> dict = new Dictionary<int, int>()
        {
            {0, 0 },
            {1,1 },
            {2,1 }
        };

        public int Fibonacci(int n)
        {
            if (dict.ContainsKey(n))
            {
                return dict[n];
            }
            return dict[n] = Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
