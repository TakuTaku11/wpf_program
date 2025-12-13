namespace wpf_TodoList
{
    /// <summary>
    /// TodoListクラス
    /// </summary>
    public class TodoList : ITodoList
    {
        /// <summary>
        /// Todoアイテムリスト
        /// </summary>
        private readonly List<TodoItem> todoItems = new();

        /// <summary>
        /// ID番号初期値
        /// </summary>
        private int idNumber = 1;

        /// <summary>
        /// IReadOnlyListでTodoItemリストを取得するプロパティ.
        /// </summary>
        public IReadOnlyList<TodoItem> Items
        {
            get { return todoItems; }
        }

        /// <summary>
        /// TodoTextを追加するメソッド.
        /// </summary>
        /// <param name="todoText">入力するTodoText.</param>
        public void AddTodoItem(string todoText)
        {
            if (!string.IsNullOrEmpty(todoText))
            {
                todoItems.Add(new TodoItem
                {
                    Id = idNumber++,
                    TodoText = todoText,
                    IsCompleted = false
                });
            }
        }

        /// <summary>
        /// TodoTextを削除するメソッド.
        /// </summary>
        /// <param name="index">削除する項目.</param>
        public void DeleteTodoItem(int index)
        {
            if (index >= 0 && index < todoItems.Count)
            {
                todoItems.RemoveAt(index);
            }
        }   
    }
}
