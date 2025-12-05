using System;
using System.Collections.Generic;
using System.Text;

namespace wpf_dentaku
{
    /// <summary>
    /// 掛け算クラス
    /// </summary>
    public class Multiply
    {
        /// <summary>
        /// 掛け算メソッド
        /// </summary>
        /// <param name="num1">掛け算に使用する数字1</param>
        /// <param name="num2">掛け算に使用する数字2</param>
        /// <returns></returns>
        public float MultiplyCalc(float num1, float num2)
        {
            float product = num1 * num2;
            return product;
        }
    }
}
