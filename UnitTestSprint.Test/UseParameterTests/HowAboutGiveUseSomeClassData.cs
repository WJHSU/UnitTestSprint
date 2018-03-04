using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSprint.Test.UseParameterTests
{
    /// <summary>
    /// Parameterized Test use ClassData
    /// This class must implement IEnumerable<object[]>
    /// 看不懂英文請自己查
    /// 你渴望了解 Enumerable 嗎?
    /// </summary>
    public class HowAboutGiveUseSomeClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 1, 1, 2 };
            yield return new object[] { 0, 1, 1 };
            yield return new object[] { 2, 2, 4 };
            yield return new object[] { 4, 4, 8 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
