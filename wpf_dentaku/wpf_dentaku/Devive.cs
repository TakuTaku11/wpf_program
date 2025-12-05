using System;
using System.Collections.Generic;
using System.Text;

namespace wpf_dentaku
{
    /// <summary>
    /// Deviceクラス
    /// </summary>
    public class Devive
    {
        /// <summary>
        /// 割り算メソッド
        /// </summary>
        /// <param name="num1">割り算に使用する数字1</param>
        /// <param name="num2">割り算に使用する数字2</param>
        /// <returns></returns>
        /// <exception cref="DivideByZeroException">割り算例外処理</exception>
        public float DivideCalc(float num1, float num2)
        {
            float quotient = num1 / num2;
            return quotient;
        }
    }
}
