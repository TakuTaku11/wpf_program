namespace wpf_TodoList
{
    /// <summary>
    /// ITodoListインターフェイス.
    /// </summary>
    public interface ITodoList
    {
        /// <summary>
        /// IReadOnlyListでTodoItemリストを取得するプロパティ.
        /// </summary>
        IReadOnlyList<TodoItem> Items { get; }

        /// <summary>
        /// AddTodoItemメソッド.
        /// </summary>
        /// <param name="todoText">入力するTodoText.</param>
        void AddTodoItem(string todoText);

        /// <summary>
        /// DeleteTodoItemメソッド.
        /// </summary>
        /// <param name="index">削除する項目.</param>
        void DeleteTodoItem(int index);
    }
}
