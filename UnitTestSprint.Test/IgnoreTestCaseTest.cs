using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestSprint.Test
{
    public class IgnoreTestCaseTest
    {
        /// <summary>
        /// 請忽略這個測試方法
        /// </summary>
        public void Test_A_Add_B_Should_Be_C()
        {
            var TheMsg = "HahahahahHehehehHooo~ERROR";
        }
    }
}
