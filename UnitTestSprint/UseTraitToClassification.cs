using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSprint
{
    /// <summary>
    /// UseTraitToClassification
    /// </summary>
    public class UseTraitToClassification
    {
        /// <summary>
        /// 加法
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int A_Add_B_Should_Be_C(int a, int b)
        {
            if (a >= int.MaxValue || b >= int.MaxValue)
            {
                throw new ApplicationException("太大惹");
            }

            return a + b;
        }

        /// <summary>
        /// 減法
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int A_Minus_B_Should_Be_C(int a, int b)
        {
            if (a <= int.MinValue)
            {
                throw new ApplicationException("太小惹");
            }

            return a - b;
        }
    }
}
