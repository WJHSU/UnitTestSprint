using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSprint.Test.UseParameterTests
{
    /// <summary>
    /// A Class Use for Data-Driven Test
    /// 在其他的 Class 內建立 MemberData Method
    /// 必須要是靜態的方法
    /// </summary>
    public class HowAboutGiveUsSomeMemberDataClass
    {
        public static IEnumerable<object[]> MemberDataProperty
        {
            get
            {
                return new List<object[]>
                {
                    new object[]{0,0,0},
                    new object[]{1,1,2},
                    new object[]{2,2,4}
                };
            }
        }

        /// <summary>
        /// OkIWillGiveYouSomeMemberData
        /// </summary>
        /// <param name="takenParameter"></param>
        /// <returns></returns>
        public static IEnumerable<object[]> OkIWillGiveYouSomeMemberData()
        {
            return new List<object[]>
            {
                new object[]{1,2,3},
                new object[]{2,3,5},
                new object[]{3,5,8},
                new object[]{5,8,13},
                new object[]{8,13,21}
            };
        }
    }
}
