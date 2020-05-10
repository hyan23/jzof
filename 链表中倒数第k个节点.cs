// 链表中倒数第k个节点.cs
// 作者: hyan23
// 2020.05.10
// https://www.nowcoder.com/practice/529d3ae5a407492994ad2a246518148a?tpId=13&tqId=11167&rp=1&ru=%2Fta%2Fcoding-interviews&qru=%2Fta%2Fcoding-interviews%2Fquestion-ranking&tPage=1

// 运行时间：36ms
// 占用内存：3564k

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

        public ListNode FindKthToTail(ListNode head, int k)
        {
            ListNode cur = head, target = head;
            int i = 0;
            while (cur != null)
            {
                if (++i > k)
                {
                    target = target.next;
                }
                cur = cur.next;
            }
            return i >= k ? target : null;
        }
    }
}
