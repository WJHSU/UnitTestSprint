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
        [Fact(Skip = "我不爽寫Test_A_Add_B_Should_Be_C")]
        public void Test_A_Add_B_Should_Be_C()
        {
            var TheMsg = "HahahahahHehehehHooo~";
        }
    }
}
