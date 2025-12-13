namespace wpf_mojisu
{
    /// <summary>
    /// LetterCountクラス.
    /// </summary>
    public class LetterCount
    {
        /// <summary>
        /// CountLettersメソッド.
        /// </summary>
        /// <param name="input">入力した文字.</param>
        /// <returns></returns>
        public int CountLetters(string? input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            return input.Length;
        }
    }
}
