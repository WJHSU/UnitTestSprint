using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestSprint.Test
{
    public class LifeTimeScopeTest : IDisposable
    {
        private static int objectCreateTimes { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LifeTimeScopeTest"/> class.
        /// 單元測試的測試類別建構子
        /// 使用Debug.Writeline 觀查生命週期
        /// </summary>
        public LifeTimeScopeTest()
        {
            Debug.WriteLine("建立 LifeTimeScopeTest 物件");

            Debug.WriteLine($"物件已被建立過 {objectCreateTimes} 次");

            LifeTimeScopeTest.objectCreateTimes++;
        }

        /// <summary>
        /// 執行與釋放 (Free)、釋放 (Release) 或重設 Unmanaged 資源相關聯之應用程式定義的工作。
        /// 使用 Debug Writeline 觀察生命週期
        /// </summary>
        public void Dispose()
        {
            Debug.WriteLine("釋放 LifeTimeScopeTest 物件");
        }

        /// <summary>
        /// test method
        /// </summary>
        /// <param name="parameter1">parameter1</param>
        /// <param name="parameter2">parameter2</param>
        /// <param name="expected">expected</param>
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 5, 8)]
        [InlineData(2, 3, 5)]
        [InlineData(11, 13, 24)]
        public void Test_A_Add_B_Should_Be_C(int parameter1, int parameter2, int expected)
        {
            //arrange
            var target = new LifeTimeScope();

            //act
            var actual = target.A_Add_B_Should_Be_C(parameter1, parameter2);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_A_Add_B_Should_Be_C_Fact()
        {
            //arrange
            var target = new LifeTimeScope();
            var parameter1 = 1;
            var parameter2 = 2;
            var expected = 3;

            //act
            var actual = target.A_Add_B_Should_Be_C(parameter1, parameter2);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
