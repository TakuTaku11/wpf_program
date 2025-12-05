using System;
using System.Collections.Generic;
using System.Text;

namespace wpf_dentaku
{
    /// <summary>
    /// 足し算クラス
    /// </summary>
    public class Add
    {
        /// <summary>
        /// 足し算メソッド
        /// </summary>
        /// <param name="num1">足し算に使用する数字1</param>
        /// <param name="num2">足し算に使用する数字2</param>
        /// <returns></returns>
        public float AddCalc(float num1, float num2)
        {
            float sum = num1 + num2;
            return sum;
        }
    }
}
