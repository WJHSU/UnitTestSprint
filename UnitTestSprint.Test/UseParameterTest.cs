using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestSprint.Test.UseParameterTests;
using Xunit;

namespace UnitTestSprint.Test
{
    public class UseParameterTest
    {
        /// <summary>
        /// Xunit 的 InlineData 要這樣用
        /// Attribute的部分，請從 Fact 改為 Theory
        /// 並且加上 InlineData Attribute
        /// </summary>
        /// <param name="parameter1">parameter1</param>
        /// <param name="parameter2">parameter2</param>
        /// <param name="expected">expected</param>
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 5)]
        [InlineData(3, 5, 8)]
        public void Test_A_Add_B_Should_Be_C_WithInlineData(int parameter1, int parameter2, int expected)
        {
            ////arrange
            var target = new UseParameter();

            ////act
            var actual = target.A_Add_B_Should_Be_C(parameter1, parameter2);

            ////assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Xunit 的 MemberData 要這樣用1
        /// 在 Test Class 內建立回傳member data 的靜態方法
        /// </summary>
        /// <param name="parameter1">parameter1</param>
        /// <param name="parameter2">parameter2</param>
        /// <param name="expected">expected</param>
        [Theory]
        [MemberData(nameof(HowAboutGiveUsSomeMemberData), parameters: 3)]
        public void Test_A_Add_B_Should_Be_C_WithmemberData1(int parameter1, int parameter2, int expected)
        {
            ////arrange
            var target = new UseParameter();

            ////act
            var actual = target.A_Add_B_Should_Be_C(parameter1, parameter2);

            ////assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Xunit 的 MemberData 要這樣用
        /// 在其他 Class 內建立回傳 MemberData 的靜態方法
        /// </summary>
        /// <param name="parameter1">parameter1</param>
        /// <param name="parameter2">parameter2</param>
        /// <param name="expected">expected</param>
        [Theory]
        [MemberData(nameof(HowAboutGiveUsSomeMemberDataClass.OkIWillGiveYouSomeMemberData), MemberType = typeof(HowAboutGiveUsSomeMemberDataClass))]
        public void Test_A_Add_B_Should_Be_C_WithmemberData2(int parameter1, int parameter2, int expected)
        {
            ////arrange
            var target = new UseParameter();

            ////act
            var actual = target.A_Add_B_Should_Be_C(parameter1, parameter2);

            ////assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Xunit 的 MemberData 要這樣用
        /// 在其他 Class 內建立 MemberData property
        /// </summary>
        /// <param name="parameter1">parameter1</param>
        /// <param name="parameter2">parameter2</param>
        /// <param name="expected">expected</param>
        [Theory]
        [MemberData(nameof(HowAboutGiveUsSomeMemberDataClass.MemberDataProperty), MemberType = typeof(HowAboutGiveUsSomeMemberDataClass))]
        public void Test_A_Add_B_Should_Be_C_WithmemberData3(int parameter1, int parameter2, int expected)
        {
            ////arrange
            var target = new UseParameter();

            ////act
            var actual = target.A_Add_B_Should_Be_C(parameter1, parameter2);

            ////assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Xunit 的 ClassData 要這樣用
        /// Create A Class Implement Ienumerable<objecet[]>
        /// </summary>
        /// <param name="parameter1">parameter1</param>
        /// <param name="parameter2">parameter2</param>
        /// <param name="expected">expected</param>
        [Theory]
        [ClassData(typeof(HowAboutGiveUseSomeClassData))]
        public void Test_A_Add_B_Should_Be_C_WithClassData(int parameter1, int parameter2, int expected)
        {
            ////arrange
            var target = new UseParameter();

            ////act
            var actual = target.A_Add_B_Should_Be_C(parameter1, parameter2);

            ////assert
            Assert.Equal(expected, actual);
        }

        #region

        /// <summary>
        /// For MemberData
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<object[]> HowAboutGiveUsSomeMemberData(int memberTaken)
        {
            var memberData = new List<object[]>
            {
                new object[] { 1, 2, 3 },
                new object[] { 2, 3, 5 },
                new object[] { 3, 5, 8 },
                new object[] { 5, 8, 13 }
            };

            return memberData.Take(memberTaken);
        }

        #endregion
    }
}