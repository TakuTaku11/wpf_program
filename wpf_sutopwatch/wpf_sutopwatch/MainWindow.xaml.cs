using System.Diagnostics;
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
using System.Windows.Threading;

namespace wpf_sutopwatch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// DispatcherTimerクラスのインスタンスを生成．
        /// </summary>
        private DispatcherTimer swtimer = new();

        /// <summary>
        /// Stopwatchクラスのインスタンスを生成．
        /// </summary>
        private Stopwatch stopwatch = new();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            swtimer.Interval = TimeSpan.FromMilliseconds(10);
            swtimer.Tick += Swtimer_Tick;
        }

        /// <summary>
        /// ストップウォッチの経過時間を表示するためのタイマーイベント
        /// </summary>
        /// <param name="sender">イベントを発生させたオブジェクト</param>
        /// <param name="e">イベントデータ</param>
        private void Swtimer_Tick(object? sender, EventArgs e)
        {
            TimeSpan ts = stopwatch.Elapsed;
            StopWatchText.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
        }

        /// <summary>
        /// ストップウォッチ開始ボタンの動作
        /// </summary>
        /// <param name="sender">イベントを発生させたオブジェクト</param>
        /// <param name="e">イベントデータ</param>
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            stopwatch.Start();
            swtimer.Start();
        }

        /// <summary>
        /// ストップウォッチ停止ボタンの動作
        /// </summary>
        /// <param name="sender">イベントを発生させたオブジェクト</param>
        /// <param name="e">イベントデータ</param>
        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            stopwatch.Stop();
            swtimer.Stop();
        }

        /// <summary>
        /// ストップウォッチリセットボタンの動作
        /// </summary>
        /// <param name="sender">イベントを発生させたオブジェクト</param>
        /// <param name="e">イベントデータ</param>
        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            stopwatch.Reset();
            StopWatchText.Text = "00:00:00.00";
        }
    }
}