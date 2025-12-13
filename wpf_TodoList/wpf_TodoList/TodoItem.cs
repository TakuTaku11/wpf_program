namespace wpf_TodoList
{
    /// <summary>
    /// Todoアイテムクラス
    /// </summary>
    public class TodoItem
    {
        /// <summary>
        /// Idプロパティ
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Todoテキストプロパティ
        /// </summary>
        public string TodoText { get; set; } = string.Empty;

        /// <summary>
        /// IsCompletedプロパティ
        /// </summary>
        public bool IsCompleted { get; set; }
    }
}
