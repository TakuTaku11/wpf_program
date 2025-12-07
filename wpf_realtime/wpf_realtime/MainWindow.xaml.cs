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

namespace wpf_realtime
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// DispatcherTimerのインスタンス
        /// </summary>
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
            
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Start();
        }

        /// <summary>
        /// 現在時刻の表示更新処理
        /// </summary>
        /// <param name="sender">イベントを発生させたオブジェクト</param>
        /// <param name="e">イベントデータ</param>
        private void DispatcherTimer_Tick(object? sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            this.TimeTextBlock.Text = now.ToString("HH:mm:ss");
        }

        /// <summary>
        /// 終了ボタン押下時の処理
        /// </summary>
        /// <param name="sender">イベントを発生させたオブジェクト</param>
        /// <param name="e">イベントデータ</param>
        private void ShutdownButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}