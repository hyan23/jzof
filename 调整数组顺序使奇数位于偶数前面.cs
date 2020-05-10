// 调整数组顺序使奇数位于偶数前面.cs
// 作者: hyan23
// 2020.05.10
// https://www.nowcoder.com/practice/beb5aa231adc45b2a5dcc5b62c93f593?tpId=13&tqId=11166&rp=1&ru=%2Fta%2Fcoding-interviews&qru=%2Fta%2Fcoding-interviews%2Fquestion-ranking&tPage=1

// 运行时间：44ms
// 占用内存：3544k

using System;
using System.Linq;

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
            Console.WriteLine(string.Join(", ", reOrderArray(new int[] { 1, 3, 5, 7, 9 })));
            Console.WriteLine(string.Join(", ", reOrderArray(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })));
        }

        public int[] reOrderArray(int[] array)
        {

            return array.Where(x => (x & 1) == 1).Concat(array.Where(x => (x & 1) == 0)).ToArray();


            /*
            int odd = 0, even = array.Length;
            while (odd < even)
            {
                if ((array[odd] & 1) == 1)
                {
                    odd++;
                }
                else
                {
                    even--;
                    int t = array[even];
                    array[even] = array[odd];
                    array[odd] = t;
                }
            }

            for (int i = 0; i < (array.Length - even) / 2; i++)
            {
                int t = array[even + i];
                array[even + i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = t;
            }
            */
            return array;
        }
    }
}
