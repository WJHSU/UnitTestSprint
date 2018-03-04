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
        /// Xunit 的 InlineData 要這樣用
        /// Attribute的部分，請從 Fact 改為 Theory
        /// 並且加上 InlineData Attribute
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

            ////act
            var ex = Assert.Throws<ApplicationException>(() => target.A_Add_B_Should_Be_C(parameter1, parameter2));

            ////assert
            Assert.Contains("GG", ex.Message);
        }
    }
}
