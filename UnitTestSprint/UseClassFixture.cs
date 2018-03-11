using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSprint
{
    /// <summary>
    /// UseClassFixture
    /// </summary>
    public class UseClassFixture
    {
        /// <summary>
        /// Target Method for UseClassFixtureTest
        /// </summary>
        /// <param name="a">a</param>
        /// <param name="b">b</param>
        /// <returns>a+b</returns>
        public int A_Add_B_Should_Be_C(int a, int b)
        {
            return a + b;
        }
    }
}
