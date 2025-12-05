using System.Numerics;
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

namespace wpf_dentaku
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Addクラスのインスタンス化
        /// </summary>
        private readonly Add add = new();

        /// <summary>
        /// Minusクラスのインスタンス化
        /// </summary>
        private readonly Minus minus = new();

        /// <summary>
        /// Multiplyクラスのインスタンス化
        /// </summary>
        private readonly Multiply multiply = new();

        /// <summary>
        /// Deviveクラスのインスタンス化
        /// </summary>
        private readonly Devive devive = new();

        /// <summary>
        /// 計算値の保持変数
        /// </summary>
        private float sum = 0;

        /// <summary>
        /// 計算符号の保持変数
        /// </summary>
        private string op = "";

        /// <summary>
        /// 0ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonInput0_Click(object sender, RoutedEventArgs e)
        {
            if (this.Calculator.Text == "0")
            {
                return;
            }

            Calculator.Text += "0";
        }

        /// <summary>
        /// 1ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonInput1_Click(object sender, RoutedEventArgs e)
        {
            if (this.Calculator.Text == "0")
            {
                return;
            }

            Calculator.Text += "1";
        }

        /// <summary>
        /// 2ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonInput2_Click(object sender, RoutedEventArgs e)
        {
            if (this.Calculator.Text == "0")
            {
                return;
            }

            Calculator.Text += "2";
        }

        /// <summary>
        /// 3ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonInput3_Click(object sender, RoutedEventArgs e)
        {
            if (this.Calculator.Text == "0")
            {
                return;
            }

            Calculator.Text += "3";
        }

        /// <summary>
        /// 4ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonInput4_Click(object sender, RoutedEventArgs e)
        {
            if (this.Calculator.Text == "0")
            {
                return;
            }

            Calculator.Text += "4";
        }

        /// <summary>
        /// 5ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonInput5_Click(object sender, RoutedEventArgs e)
        {
            if (this.Calculator.Text == "0")
            {
                return;
            }

            Calculator.Text += "5";
        }

        /// <summary>
        /// 6ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonInput6_Click(object sender, RoutedEventArgs e)
        {
            if (this.Calculator.Text == "0")
            {
                return;
            }

            Calculator.Text += "6";
        }

        /// <summary>
        /// 7ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonInput7_Click(object sender, RoutedEventArgs e)
        {
            if (this.Calculator.Text == "0")
            {
                return;
            }

            Calculator.Text += "7";
        }

        /// <summary>
        /// 8ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonInput8_Click(object sender, RoutedEventArgs e)
        {
            if (this.Calculator.Text == "0")
            {
                return;
            }

            Calculator.Text += "8";
        }

        /// <summary>
        /// 9ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonInput9_Click(object sender, RoutedEventArgs e)
        {
            if (this.Calculator.Text == "0")
            {
                return;
            }

            Calculator.Text += "9";
        }

        /// <summary>
        /// クリアボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorClear_Click(object sender, RoutedEventArgs e)
        {
            this.Calculator.Text = string.Empty;
        }

        /// <summary>
        /// 入力した数値の正負を切り替える処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlusMinusChange_Click(object sender, RoutedEventArgs e)
        {
            float number = float.Parse(this.Calculator.Text);
            if (number > 0)
            {
                this.Calculator.Text = "-" + this.Calculator.Text;
                return;
            }
            this.Calculator.Text = this.Calculator.Text.TrimStart('-');
        }

        /// <summary>
        /// パーセント変換処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PercentChange_Click(object sender, RoutedEventArgs e)
        {
            float number = float.Parse(this.Calculator.Text);
            number = number / 100;
            this.Calculator.Text = number.ToString();
        }

        /// <summary>
        /// 足し算ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            sum = float.Parse(Calculator.Text);      
            op = "+";
            Calculator.Clear();               
        }

        /// <summary>
        /// 引き算ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            sum = float.Parse(Calculator.Text);
            op = "-";
            Calculator.Clear();
        }

        /// <summary>
        /// 掛け算ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            sum = float.Parse(Calculator.Text);
            op = "*";
            Calculator.Clear();
        }

        /// <summary>
        /// 割り算ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Devive_Click(object sender, RoutedEventArgs e)
        {
            sum = float.Parse(Calculator.Text);
            op = "/";
            Calculator.Clear();
        }

        /// <summary>
        /// 小数点ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Demical_Click(object sender, RoutedEventArgs e)
        {
            if (this.Calculator.Text.Contains("."))
            {
                return;
            }
            if (this.Calculator.Text == "")
            {
                this.Calculator.Text = "0.";
                return;
            }

            this.Calculator.Text += ".";
        }

        /// <summary>
        /// 計算結果を表示する処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorResult_Click(object sender, RoutedEventArgs e)
        {
            float number = float.Parse(Calculator.Text);

            if (op == "+")
            {
                sum = add.AddCalc(sum, number);
                Calculator.Text = sum.ToString();
                return;
            }
            if (op == "-")
            {
                sum = minus.MinusCalc(sum, number);
                Calculator.Text = sum.ToString();
                return;
            }
            if (op == "*")
            {
                sum = multiply.MultiplyCalc(sum,number);
                Calculator.Text = sum.ToString();
                return;
            }
            if (op == "/")
            {
                sum = devive.DivideCalc(sum,number);
                Calculator.Text = sum.ToString();
                return;
            }
        }
    }
}