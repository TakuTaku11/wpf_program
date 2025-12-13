namespace wpf_TodoListTests
{
    using wpf_TodoList;

    /// <summary>
    /// TodoListTestsクラス
    /// </summary>
    public  class TodoListTests
    {
        /// <summary>
        /// TodoListにリストが追加されることを確認するテスト．
        /// </summary>
        [Test]
        public void AddTodoItem_TodoItemIsAdd()
        {
            var todoList = new TodoList();

            todoList.AddTodoItem("Test Item 1");

            Assert.That(todoList.Items.Count, Is.EqualTo(1));
        }

        /// <summary>
        /// TodoListが空文字のとき，リストが追加されない事を確認するテスト．
        /// </summary>
        [Test]
        public void AddTodoItem_EmptyString_NoItemAdded()
        {
            var todoList = new TodoList();
 
            Assert.That(todoList.Items.Count, Is.EqualTo(0));
        }

        /// <summary>
        /// 選択項目が削除されることを確認するテスト．
        /// </summary>
        [Test]
        public void DeleteTodoItem_SelectedItemIsDeleted()
        {
            var todoList = new TodoList();

            todoList.AddTodoItem("Test Item 1");

            todoList.AddTodoItem("Test Item 2");

            todoList.DeleteTodoItem(0);

            Assert.That(todoList.Items[0].TodoText, Is.EqualTo("Test Item 2"));
        }

        /// <summary>
        /// 選択項目が範囲外のとき，削除されないことを確認するテスト．（負の値）
        /// </summary>
        [Test]
        public void DeleteTodoItem_IndexOutOfRange_Negative_NoItemDeleted()
        {
            var todoList = new TodoList();

            todoList.AddTodoItem("Test Item 1");

            todoList.DeleteTodoItem(-1);

            Assert.That(todoList.Items.Count, Is.EqualTo(1));
        }

        /// <summary>
        /// 選択項目が範囲外のとき，削除されないことを確認するテスト．（正の値）
        /// </summary>
        [Test]
        public void DeleteTodoItem_IndexOutOfRange_Positive_NoItemDeleted()
        {
            var todoList = new TodoList();

            todoList.AddTodoItem("Test Item 1");

            todoList.DeleteTodoItem(3);

            Assert.That(todoList.Items.Count, Is.EqualTo(1));
        }

        /// <summary>
        /// リストの初期値が空であることを確認するテスト．
        /// </summary>
        [Test]
        public void IReadOnlyList_DefaultValue_IsEmpty()
        {
            var todoList = new TodoList();

            Assert.That(todoList.Items.Count, Is.EqualTo(0));
        }

        [Test]
        public void AddMultipleTodoItems_ItemsAreAddedCorrectly()
        {
            var todoList = new TodoList();

            todoList.AddTodoItem("Task 1");

            todoList.AddTodoItem("Task 2");

            Assert.That(todoList.Items.Count, Is.EqualTo(2));
        }
    }
}
