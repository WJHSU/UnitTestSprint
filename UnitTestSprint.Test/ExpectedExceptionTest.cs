using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestSprint.Test
{
    public class ExpectedExceptionTest
    {
        /// <summary>
        /// 驗證 Exception 是否符合預期
        /// </summary>
        /// <param name="parameter1">parameter1</param>
        /// <param name="parameter2">parameter2</param>
        /// <param name="expected">expected</param>
        [Fact]
        public void Test_A_Add_B_Should_Be_C_ThrowException()
        {
            ////arrange
            var target = new ExpectedException();
            var parameter1 = int.MaxValue;
            var parameter2 = 1;
            ////adding other parameter here

            ////請用 Assert.Throws 驗證拋出之 Exception Type 是否符合預期

            ////請驗證拋出的訊息是否符合預期
        }
    }
}
