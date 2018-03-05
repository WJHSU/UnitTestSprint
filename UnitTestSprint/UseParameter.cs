using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSprint
{
    /// <summary>
    /// 現在來試看看各種 Parameterized Test
    /// 我們的目標方法還是只有一個
    /// 而且和UnitTestBasic一樣
    /// 哈哈哈
    /// </summary>
    public class UseParameter
    {
        /// <summary>
        /// 和UnitTestBasic一樣的方法
        /// Ctrl + C -> Ctrl + V
        /// </summary>
        /// <param name="a">你覺得呢?</param>
        /// <param name="b">你覺得呢?</param>
        /// <returns>你又怎麼覺得呢?></returns>
        public int A_Add_B_Should_Be_C(int a, int b)
        {
            return a + b;
        }
    }
}
