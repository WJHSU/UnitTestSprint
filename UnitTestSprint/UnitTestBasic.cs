using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSprint
{
    /// <summary>
    /// Unit Test 101
    /// 你的第一個單元測試的目標，是個非常單純的加法方法
    /// 這個都不會的話
    /// 世界很大，不是一定要當工程師
    /// </summary>
    public class UnitTestBasic
    {
        /// <summary>
        /// 剛剛上面講到的加法
        /// 怕你看不懂，我幫你加注音
        /// </summary>
        /// <param name="a">被(ㄅㄟˋ)加(ㄐㄧㄚ)數(ㄕㄨˋ)</param>
        /// <param name="b">加(ㄐㄧㄚ)數(ㄕㄨˋ)</param>
        /// <returns>和(ㄏㄜˊ)</returns>
        public int A_Add_B_Should_Be_C(int a, int b)
        {
            return a + b;
        }
    }
}
