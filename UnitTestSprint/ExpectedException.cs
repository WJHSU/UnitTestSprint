using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSprint
{
    public class ExpectedException
    {
        /// <summary>
        /// 目標方法針對傳遞參數是否大於等於int的最大值，判斷決定是否要 throw exception
        /// </summary>
        /// <param name="a">你覺得呢?</param>
        /// <param name="b">你覺得呢?</param>
        /// <returns>你又怎麼覺得呢?</returns>
        public int A_Add_B_Should_Be_C(int a, int b)
        {
            if (a >= int.MaxValue)
            {
                throw new ApplicationException("被加數再加上去就GG惹");
            }

            if (b >= int.MaxValue)
            {
                throw new ApplicationException("加數再加上去就GG惹");
            }

            return a + b;
        }
    }
}
