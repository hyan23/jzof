// 跳台阶.cs
// 作者: hyan23
// 2020.05.08
// https://www.nowcoder.com/practice/8c82a5b80378478f9484d87d1c5f12a4?tpId=13&tqId=11161&tPage=1&rp=1&ru=%2Fta%2Fcoding-interviews&qru=%2Fta%2Fcoding-interviews%2Fquestion-ranking

// 运行时间：1865ms
// 占用内存：3420k

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

        public int jumpFloor(int number)
        {
            int ans = 0;
            Helper(number, ref ans);
            return ans;
        }

        private void Helper(int number, ref int ans)
        {
            if (number > 1)
            {
                Helper(number - 2, ref ans);
                Helper(number - 1, ref ans);
            }
            else if (number > 0)
            {
                Helper(number - 1, ref ans);
            }
            else
            {
                ans++;
            }
        }
    }
}
