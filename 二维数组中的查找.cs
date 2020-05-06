// 二维数组中的查找.cs
// 作者: hyan23
// 2020.05.06
// https://www.nowcoder.com/practice/abc3fe2ce8e146608e868a70efebf62e?tpId=13&tqId=11154&tPage=1&rp=1&ru=/ta/coding-interviews&qru=/ta/coding-interviews/question-ranking

// 运行时间：57ms
// 占用内存：6380k

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

        public bool Find(int target, int[][] array)
        {
            if (array.Length == 0 || array[0].Length == 0)
            {
                return false;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i][0] <= target)
                {
                    if (BinarySearch(array[i], target))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool BinarySearch(int[] array, int target)
        {
            int left = 0, right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int elem = array[mid];

                if (elem > target)
                {
                    right = mid - 1;
                }
                else if (elem < target)
                {
                    left = mid + 1;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
    }
}
