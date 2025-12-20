namespace wpf_counterTests
{
    using wpf_counter;

    /// <summary>
    /// CountTestのクラス.
    /// </summary>
    internal class CountTests
    {
        /// <summary>
        /// 数字が1ずつ増える確認をするテスト．
        /// </summary>
        [Test]
        public void Number_Plus()
        {
            var count = new Count();

            int add = count.Plus();

            Assert.That(add, Is.EqualTo(1));
        }

        /// <summary>
        /// 表示されている数字が0のときに，数が減らないことを確認するテスト．
        /// </summary>
        [Test]
        public void Number_Minus_Zero()
        {
            var count = new Count();

            int sub = count.Minus();

            Assert.That(sub, Is.EqualTo(0));
        }

        /// <summary>
        /// 表示されている数字が0以上のときに，数が1ずつ減ることを確認するテスト．
        /// </summary>
        [Test]
        public void Number_Minus_Not_Zero()
        {
            var count = new Count();

            // まず1増やす
            count.Plus();

            int sub = count.Minus();

            Assert.That(sub, Is.EqualTo(0));
        }

        /// <summary>
        /// カウントがクリアされることを確認するテスト．
        /// </summary>
        [Test]
        public void Number_Clear()
        {
            var count = new Count();

            // まず1増やす
            count.Plus();

            int clear = count.Clear();

            Assert.That(clear, Is.EqualTo(0));
        }
    }
}
