namespace wpf_TodoListTests
{
    using wpf_TodoList;

    /// <summary>
    /// TodoItemテストクラス
    /// </summary>
    public class TodoItemTests
    {
        /// <summary>
        /// Idの値の初期値のテスト.
        /// </summary>
        [Test]
        public void Id_DefaultValue_IsZero()
        {
            var item = new TodoItem();

            Assert.That(item.Id, Is.EqualTo(0));
        }

        /// <summary>
        /// TodoTextの初期値のテスト.
        /// </summary>
        [Test]
        public void TodoText_Empty()
        {
            var item = new TodoItem();

            Assert.That(item.TodoText, Is.EqualTo(string.Empty));
        }

        /// <summary>
        /// IsCompletedの初期値のテスト．
        /// </summary>
        [Test]
        public void IsCompleted_Default()
        {
            var item = new TodoItem();

            Assert.That(item.IsCompleted, Is.EqualTo(false));
        }

        /// <summary>
        /// Idに入力した番号のテスト．
        /// </summary>
        [Test]
        public void Id_InputNumber()
        {
            var item = new TodoItem();

            item.Id = 1;

            Assert.That(item.Id, Is.EqualTo(1));
        }

        /// <summary>
        /// TodoTextに入力したときのテスト．
        /// </summary>
        [Test]
        public void TodoText_Input()
        {
            var item = new TodoItem();

            item.TodoText = "aaa";

            Assert.That(item.TodoText, Is.EqualTo("aaa"));
        }

        /// <summary>
        /// IsCompletedがtrueのときのテスト．
        /// </summary>
        [Test]
        public void IsCompleted_True()
        {
            var item = new TodoItem();

            item.IsCompleted = true;

            Assert.That(item.IsCompleted, Is.EqualTo(true));
        }
    }
}
