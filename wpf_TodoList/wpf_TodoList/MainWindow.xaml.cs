using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_TodoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
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
        /// コンストラクタ
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            // TodoリストのItemsSourceにバインド
            TodoListBox.ItemsSource = todoItems;
        }

        /// <summary>
        /// Todoアイテムリスト
        /// </summary>

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

            todoItems.Add(new TodoItem
            {
                Id = idNumber++,
                TodoText = todoText,
                IsCompleted = false
            });

            TodoListBox.Items.Refresh();
            TodoTextBox.Clear();
        }

        /// <summary>
        /// コンテキストメニューの削除ボタン押下時の処理
        /// </summary>
        /// <param name="sender">イベントを発生させたオブジェクト</param>
        /// <param name="e">イベントデータ</param>
        private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {
            todoItems.Remove((TodoItem)TodoListBox.SelectedItem);
            TodoListBox.Items.Refresh();
        }
    }
}