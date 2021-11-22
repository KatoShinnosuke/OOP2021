using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberGame
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        private static int ans = 0;
        public MainWindow()
        {
            ans = random.Next(1, 26);
                InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChangeBackground((Button)e.Source);
            ResultText((Button)e.Source);
        }
        
        private void ChangeBackground(Button button)
        {
            button.Background = Brushes.Gray;
        }
        private void ResultText(Button button)
        {
            int bt_num = int.Parse(button.Content.ToString());
            if (ans > bt_num)
            {
                tb.Text = "もっと大きい";
            }
            else if (ans < bt_num)
            {
                tb.Text = "もっと小さい";
            }
            else
            {
                button.Background = Brushes.OrangeRed;
                tb.Text = "正解";
            }
        }

        private void bt_1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt_9_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
