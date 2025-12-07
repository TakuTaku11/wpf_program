using Microsoft.Win32;
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

namespace wpf_memo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// SaveFileDialogのインスタンス
        /// </summary>
        private SaveFileDialog saveFileDialog = new SaveFileDialog();

        /// <summary>
        /// OpenFileDialogのインスタンス
        /// </summary>
        private OpenFileDialog openFileDialog = new OpenFileDialog();

        /// <summary>
        /// TextBoxに入力された文字をテキストファイルとして保存するメソッド
        /// </summary>
        /// <param name="sender">イベントを発生させたオブジェクト</param>
        /// <param name="e">イベントデータ</param>
        private void SaveMemoButton_Click(object sender, RoutedEventArgs e)
        {
            saveFileDialog.FileName = "memo.txt";
            saveFileDialog.Filter = "テキストファイル (*.txt)|*.txt|すべてのファイル (*.*)|*.*";
            saveFileDialog.Title = "メモの保存先を選択してください";

            if (saveFileDialog.ShowDialog() == true)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, MemoTextBox.Text, Encoding.UTF8);
            }
        }

        /// <summary>
        /// 既にあるテキストファイルを読み込んで、テキストボックスに表示するメゾット
        /// </summary>
        /// <param name="sender">イベントを発生させたオブジェクト</param>
        /// <param name="e">イベントデータ</param>
        private void OpenMemoButton_Click(object sender, RoutedEventArgs e)
        {
            openFileDialog.Filter = "テキストファイル (*.txt)|*.txt|すべてのファイル (*.*)|*.*";
            openFileDialog.Title = "メモを開くファイルを選択してください";
            if (openFileDialog.ShowDialog() == true)
            {
                MemoTextBox.Text = System.IO.File.ReadAllText(openFileDialog.FileName, Encoding.UTF8);
            }
        }

        /// <summary>
        /// テキストボックスの内容をクリアするメソッド
        /// </summary>
        /// <param name="sender">イベントを発生させたオブジェクト</param>
        /// <param name="e">イベントデータ</param>
        private void ClearMemoButton_Click(object sender, RoutedEventArgs e)
        {
            MemoTextBox.Clear();
        }
    }
}