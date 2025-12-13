namespace wpf_mojisuTests
{
    using wpf_mojisu;
    using wpf_mojisuTests;
    /// <summary>
    /// LetterCountクラスのテスト
    /// </summary>
    public class LetterCountTests
    {
        /// <summary>
        /// 入力した文字数が空文字の場合のテスト．
        /// </summary>
        [Test]
        public void CountLetters_InputNothing()
        {
            var letterCount = new LetterCount();

            Assert.That(letterCount.CountLetters(string.Empty), Is.EqualTo(0));
        }

        /// <summary>
        /// 入力した文字数がある場合のテスト．
        /// </summary>
        [Test]
        public void ConuntLetters_InputOneCharacter()
        {
            var letterCount = new LetterCount();

            int count = letterCount.CountLetters("aaa");

            Assert.That(count, Is.EqualTo(3));
        }

        /// <summary>
        /// 入力する文字がnullであるときのテスト．
        /// </summary>
        [Test]
        public void ConutLetters_InputNull()
        {
            var letterCount = new LetterCount();

            int count = letterCount.CountLetters(null);

            Assert.That(count, Is.EqualTo(0));
        }
    }
}
