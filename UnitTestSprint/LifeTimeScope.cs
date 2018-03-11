using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSprint
{
    /// <summary>
    /// 用來 demo Test Method 生命週期所用的 target class
    /// </summary>
    public class LifeTimeScope
    {
        /// <summary>
        /// target method
        /// </summary>
        /// <param name="a">parameter a</param>
        /// <param name="b">parameter b</param>
        /// <returns>sum</returns>
        public int A_Add_B_Should_Be_C(int a, int b)
        {
            return a + b;
        }
    }
}
