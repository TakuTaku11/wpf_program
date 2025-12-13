namespace wpf_TodoList
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// TodoListクラスのインスタンス
        /// </summary>
        private readonly ITodoList todoList = new TodoList();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 追加ボタン押下時の処理
        /// </summary>
        /// <param name="sender">イベントを発生させたオブジェクト</param>
        /// <param name="e">イベントデータ</param>
        private void TodoAddButton_Click(object sender, RoutedEventArgs e)
        {
            string todoText = TodoTextBox.Text;

            if(string.IsNullOrWhiteSpace(todoText))
            {
                this.Close();
                return;
            }

            todoList.AddTodoItem(todoText);

            TodoListBox.ItemsSource = todoList.Items.ToList();

            TodoTextBox.Clear();
        }

        /// <summary>
        /// コンテキストメニューの削除ボタン押下時の処理
        /// </summary>
        /// <param name="sender">イベントを発生させたオブジェクト</param>
        /// <param name="e">イベントデータ</param>
        private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {
            int index = TodoListBox.SelectedIndex;

            todoList.DeleteTodoItem(index);

            TodoListBox.ItemsSource = todoList.Items.ToList();
        }
    }
}