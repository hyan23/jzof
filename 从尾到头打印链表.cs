// 从尾到头打印链表.cs
// 作者: hyan23
// 2020.05.06
// https://www.nowcoder.com/practice/d0267f7f55b3412ba93bd35cfa8e8035?tpId=13&tqId=11156&tPage=1&rp=1&ru=%2Fta%2Fcoding-interviews&qru=%2Fta%2Fcoding-interviews%2Fquestion-ranking

// 运行时间：36ms
// 占用内存：3284k

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

        public List<int> printListFromTailToHead(ListNode listNode)
        {
            Stack<int> st = new Stack<int>();
            ListNode cur = listNode;
            while (cur != null)
            {
                st.Push(cur.val);
                cur = cur.next;
            }

            List<int> result = new List<int>();
            while (st.Count > 0)
            {
                result.Add(st.Pop());
            }

            return result;
        }
    }
}
