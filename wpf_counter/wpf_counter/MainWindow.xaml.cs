namespace wpf_counter
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Countクラスのインスタンス化．
        /// </summary>
        private readonly Count count = new Count();

        /// <summary>
        /// コンストラクタ.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 数字を1増やす関数．
        /// </summary>
        /// <param name="sender">イベントを発生させたオブジェクト．</param>
        /// <param name="e">イベントデータ．</param>
        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            CounterTextBlock.Text = count.Plus().ToString();
        }

        /// <summary>
        /// 数字を1減らす関数．
        /// </summary>
        /// <param name="sender">イベントを発生させたオブジェクト．</param>
        /// <param name="e">イベントデータ．</param>
        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            CounterTextBlock.Text = count.Minus().ToString();
        }

        /// <summary>
        /// 数字を0に戻す関数．
        /// </summary>
        /// <param name="sender">イベントを発生させたオブジェクト．</param>
        /// <param name="e">イベントデータ．</param>
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            CounterTextBlock.Text = count.Clear().ToString();
        }
    }
}