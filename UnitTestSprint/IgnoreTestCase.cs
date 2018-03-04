using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSprint
{
    public class IgnoreTestCase
    {
        /// <summary>
        /// 我只是需要一個拿來 demo 掠過某些測項方法的target method
        /// </summary>
        /// <param name="a">你覺得呢?</param>
        /// <param name="b">你覺得呢?</param>
        /// <returns>你又怎麼覺得呢?</returns>
        public int A_Add_B_Should_Be_C(int a, int b)
        {
            return a + b;
        }
    }
}
