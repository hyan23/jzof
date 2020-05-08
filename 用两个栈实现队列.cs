// 用两个栈实现队列.cs
// 作者: hyan23
// 2020.05.06
// https://www.nowcoder.com/practice/54275ddae22f475981afa2244dd448c6?tpId=13&tqId=11158&tPage=1&rp=1&ru=%2Fta%2Fcoding-interviews&qru=%2Fta%2Fcoding-interviews%2Fquestion-ranking

// 运行时间：42ms
// 占用内存：3708k

using System.Collections.Generic;

namespace csharp
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
        }
    }

    public class Program
    {
        public static void Main()
        {
            new Program().Test();
        }

        public void Test()
        {
        }

        Stack<int> st = new Stack<int>();

        public void push(int node)
        {
            st.Push(node);
        }

        public int pop()
        {
            Stack<int> q = new Stack<int>();
            while (st.Count > 0)
            {
                q.Push(st.Pop());
            }

            int v = q.Pop();

            while (q.Count > 0)
            {
                st.Push(q.Pop());
            }

            return v;
        }
    }
}
