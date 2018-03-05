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
        /// 請在 UseParameterTests資料夾內建立新的Class，此 Class 包含一個回傳 IEnumerable<object[]> 的靜態方法
        /// </summary>
        /// <param name="parameter1">parameter1</param>
        /// <param name="parameter2">parameter2</param>
        /// <param name="expected">expected</param>
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
        /// 在剛剛的 Class 內建立一靜態屬性，並建立 get 存取子回傳一 object[] 的 list
        /// </summary>
        /// <param name="parameter1">parameter1</param>
        /// <param name="parameter2">parameter2</param>
        /// <param name="expected">expected</param>
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
        /// 你所建立的Class必須要實作 Ienumerable 介面
        /// Create A Class Implement Ienumerable<objecet[]>
        /// </summary>
        /// <param name="parameter1">parameter1</param>
        /// <param name="parameter2">parameter2</param>
        /// <param name="expected">expected</param>
        public void Test_A_Add_B_Should_Be_C_WithClassData(int parameter1, int parameter2, int expected)
        {
            ////arrange
            var target = new UseParameter();

            ////act
            var actual = target.A_Add_B_Should_Be_C(parameter1, parameter2);

            ////assert
            Assert.Equal(expected, actual);
        }

        #region:return memberdata

        /// <summary>
        /// 請在此區塊建立一個回傳 Ienumerable<object[]>的方法
        /// For MemberData
        /// </summary>
        /// <returns></returns>
        #endregion
    }
}