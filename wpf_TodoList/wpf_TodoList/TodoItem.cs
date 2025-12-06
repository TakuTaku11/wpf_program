using System;
using System.Collections.Generic;
using System.Text;

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
        public string TodoText { get; set; }

        /// <summary>
        /// IsCompletedプロパティ
        /// </summary>
        public bool IsCompleted { get; set; }
    }
}
