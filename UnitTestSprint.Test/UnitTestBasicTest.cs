using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using UnitTestSprint;

namespace UnitTestSprint.Test
{
    /// <summary>
    /// Unit Test 101
    /// Coding Standard : TargetClass{Test}
    /// </summary>
    public class UnitTestBasicTest
    {
        /// <summary>
        /// 方法須加上 Fact Attribute.否則你的 UT runner 不會跑這段UT
        /// Coding Standard : {Test}_TargetMethod
        /// </summary>
        [Fact]
        public void Test_A_Add_B_Should_Be_C()
        {
            ////arrange
            var target = new UnitTestBasic();
            var parameter1 = 1;
            var parameter2 = 2;

            ////adding other parameter here
            var expected = 3;

            ////act
            var actual = target.A_Add_B_Should_Be_C(parameter1, parameter2);

            ////assert
            Assert.Equal(expected, actual);
        }
    }
}
