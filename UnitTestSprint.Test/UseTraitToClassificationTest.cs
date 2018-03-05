using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestSprint.Test
{
    /// <summary>
    /// UseTraitToClassificationTest
    /// 以下四個方法，分別針對加法和減法，進行 return value 與 throw exception 的驗證
    /// 請分類
    /// 3q
    /// </summary>
    public class UseTraitToClassificationTest
    {

        /// <summary>
        /// 加法的測試
        /// </summary>
        [Fact]
        public void Test_A_Add_B_Should_Be_C()
        {
            ////arrange
            var target = new UseTraitToClassification();
            var parameter1 = 1;
            var parameter2 = 2;

            ////adding other parameter here
            var expected = 3;

            ////act
            var actual = target.A_Add_B_Should_Be_C(parameter1, parameter2);

            ////assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// 加法的測試
        /// </summary>
        [Fact]
        public void Test_A_Add_B_Should_Be_C1()
        {
            ////arrange
            var target = new UseTraitToClassification();
            var parameter1 = int.MaxValue;
            var parameter2 = 4;

            ////adding other parameter here
            var expected = "太大惹";

            ////act
            var ex = Assert.Throws<ApplicationException>(() => target.A_Add_B_Should_Be_C(parameter1, parameter2));

            ////assert
            Assert.Equal(expected, ex.Message);
        }

        /// <summary>
        /// 減法的測試
        /// </summary>
        [Fact]
        public void Test_A_Minus_B_Should_Be_C()
        {
            ////arrange
            var target = new UseTraitToClassification();
            var parameter1 = 3;
            var parameter2 = 2;
            ////adding other parameter here
            var expected = 1;

            ////act
            var actual = target.A_Minus_B_Should_Be_C(parameter1, parameter2);

            ////assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// 減法的測試
        /// </summary>
        [Fact]
        public void Test_A_Minus_B_Should_Be_C1()
        {
            ////arrange
            var target = new UseTraitToClassification();
            var parameter1 = int.MinValue;
            var parameter2 = 3;
            ////adding other parameter here
            var expected = "太小惹";

            ////act
            var ex = Assert.Throws<ApplicationException>(() => target.A_Minus_B_Should_Be_C(parameter1, parameter2));

            ////assert
            Assert.Equal(expected, ex.Message);
        }
    }
}
