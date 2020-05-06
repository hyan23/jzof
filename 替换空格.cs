// 替换空格.cs
// 作者: hyan23
// 2020.05.06
// https://www.nowcoder.com/practice/4060ac7e3e404ad1a894ef3e17650423?tpId=13&tqId=11155&tPage=1&rp=1&ru=%2Fta%2Fcoding-interviews&qru=%2Fta%2Fcoding-interviews%2Fquestion-ranking

// 运行时间：42ms
// 占用内存：3608k

using System.Text;

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

        public string replaceSpace(string str)
        {
            StringBuilder sb = new StringBuilder();

            int pos = 0;
            while (pos < str.Length)
            {
                int idx = str.IndexOf(' ', pos);
                if (idx >= 0)
                {
                    sb.Append(str, pos, idx - pos);
                    sb.Append("%20");
                    pos = idx + 1;
                }
                else
                {
                    sb.Append(str, pos, str.Length - pos);
                    pos = str.Length;
                }
            }

            return sb.ToString();
        }
    }
}
