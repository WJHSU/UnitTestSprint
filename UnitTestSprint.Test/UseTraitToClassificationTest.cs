using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestSprint.Test
{
    public class UseTraitToClassificationTest
    {
        [Fact]
        [Trait("UseTraitToClassificationTest", "Plus")]
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

        [Fact]
        [Trait("UseTraitToClassificationTest2", "Plus")]
        public void Test_A_Add_B_Should_Be_C1()
        {
            ////arrange
            var target = new UseTraitToClassification();
            var parameter1 = 2;
            var parameter2 = 4;

            ////adding other parameter here
            var expected = 6;

            ////act
            var actual = target.A_Add_B_Should_Be_C(parameter1, parameter2);

            ////assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        [Trait("UseTraitToClassificationTest", "Minus")]
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

        [Fact]
        [Trait("UseTraitToClassificationTest2", "Minus")]
        public void Test_A_Minus_B_Should_Be_C1()
        {
            ////arrange
            var target = new UseTraitToClassification();
            var parameter1 = 5;
            var parameter2 = 3;
            ////adding other parameter here
            var expected = 2;

            ////act
            var actual = target.A_Minus_B_Should_Be_C(parameter1, parameter2);

            ////assert
            Assert.Equal(expected, actual);
        }
    }
}
