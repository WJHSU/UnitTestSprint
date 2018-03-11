using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestSprint.Test
{
    /// <summary>
    /// Test Class
    /// </summary>
    public class UseClassFixtureTest : IClassFixture<StringContext>
    {
        private StringContext dbCOntext;

        public UseClassFixtureTest(StringContext dbContext)
        {
            Debug.WriteLine("Create UseClassFixtureTet Object");

            this.dbCOntext = dbContext;
        }


        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 3, 6)]
        public void Test_A_Add_B_Should_Be_C(int parameter1, int parameter2, int expected)
        {
            ////arrange
            var target = new UseClassFixture();

            ////act
            var actual = target.A_Add_B_Should_Be_C(parameter1, parameter2);

            ////assert
            Assert.Equal(expected, actual);
        }
    }

    /// <summary>
    /// DbContext
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public class StringContext : IDisposable
    {
        private string theString;

        public StringContext()
        {
            Debug.WriteLine("DbContext Create");

            this.theString = "123";
        }

        public void Dispose()
        {
            Debug.WriteLine("DbContext Dispose");
        }
    }
}
