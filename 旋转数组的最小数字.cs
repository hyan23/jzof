// 旋转数组的最小数字.cs
// 作者: hyan23
// 2020.05.08
// https://www.nowcoder.com/practice/9f3231a991af4f55b95579b44b7a01ba?tpId=13&tqId=11159&tPage=1&rp=1&ru=/ta/coding-interviews&qru=/ta/coding-interviews/question-ranking

// 运行时间：88ms
// 占用内存：13192k

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
            Console.WriteLine(minNumberInRotateArray(new int[] { 3, 3, 3, 3, 3, 1, 2 }));
            Console.WriteLine(minNumberInRotateArray(new int[] { 3, 1, 2, 3, 3, 3, 3, 3, 3, 3 }));
        }

        public int minNumberInRotateArray(int[] rotateArray)
        {
            if (rotateArray.Length == 0)
            {
                return 0;
            }

            int first = rotateArray[0], last = rotateArray[rotateArray.Length - 1];
            int min = rotateArray[0];

            int left = 0, right = rotateArray.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int midVal = rotateArray[mid];

                min = Math.Min(min, midVal);

                if (midVal < first)
                {
                    right = mid - 1;
                }
                else if (midVal > first)
                {
                    left = mid + 1;
                }
                else
                {
                    if (midVal > last)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }

            return min;
        }
    }
}
