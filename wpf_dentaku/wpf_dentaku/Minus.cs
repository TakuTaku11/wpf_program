using System;
using System.Collections.Generic;
using System.Text;

namespace wpf_dentaku
{
    /// <summary>
    /// Minusクラス
    /// </summary>
    public class Minus
    {
        /// <summary>
        /// 引き算メソッド
        /// </summary>
        /// <param name="num1">引き算で使用する数字1</param>
        /// <param name="num2">引き算で使用する数字2</param>
        /// <returns></returns>
        public float MinusCalc(float num1, float num2)
        {
            float difference = num1 - num2;
            return difference;
        }
    }
}
