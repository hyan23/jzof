// 二进制中1的个数.cs
// 作者: hyan23
// 2020.05.08
// https://www.nowcoder.com/practice/8ee967e43c2c4ec193b040ea7fbb10b8?tpId=13&tqId=11164&rp=1&ru=/ta/coding-interviews&qru=/ta/coding-interviews/question-ranking

// 运行时间：25ms
// 占用内存：3404k

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

        public int NumberOf1(int n)
        {
            int cnt = 0;
            while (n != 0)
            {
                cnt += n & 1;
                n = (int)((uint)n >> 1);
            }
            return cnt;
        }
    }
}
