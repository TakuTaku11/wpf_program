namespace wpf_counter
{
    /// <summary>
    /// Countクラス.
    /// </summary>
    public class Count
    {
        /// <summary>
        /// 数字の初期値．
        /// </summary>
        private int counter = 0;

        /// <summary>
        /// 数字が1つずつ増えるメソッド．
        /// </summary>
        /// <returns>足された数字．</returns>
        public int Plus()
        {
            counter++;
            return counter;
        }

        /// <summary>
        /// 数字が1つずつ減るメソッド．
        /// </summary>
        /// <returns>引かれた数字．</returns>
        public int Minus()
        {
            counter--;

            if (counter < 0)
            {
                counter = 0;
            }

            return counter;
        }

        /// <summary>
        /// 数字のクリア動作
        /// </summary>
        /// <returns>0の出力.</returns>
        public int Clear()
        {
            counter = 0;

            return counter;
        }
    }
}
