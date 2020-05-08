// 矩形覆盖.cs
// 作者: hyan23
// 2020.05.08
// https://www.nowcoder.com/practice/72a5a919508a4251859fb2cfb987a0e6?tpId=13&tqId=11163&rp=1&ru=%2Fta%2Fcoding-interviews&qru=%2Fta%2Fcoding-interviews%2Fquestion-ranking

// 运行时间：37ms
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
            {2,2 }
        };

        public int Fibonacci变体(int n)
        {
            if (dict.ContainsKey(n))
            {
                return dict[n];
            }
            return dict[n] = Fibonacci变体(n - 1) + Fibonacci变体(n - 2);
        }

        public int rectCover(int number)
        {
            return Fibonacci变体(number);
        }
    }
}
