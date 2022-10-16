using System.Windows;
using System.Windows.Controls;

namespace wpf_calculator.Trainings._2_EventHandling.demo
{
    /// <summary>
    /// Interaction logic for DemoWindow.xaml
    /// </summary>
    public partial class DemoWindow : Window
    {
        int num1 = 0;
        int num2 = 0;
        string op = "";

        public DemoWindow()
        {
            InitializeComponent();
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text = "7";
        }

        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            num1 = num1 * 10 + 8;
            txtValue.Text = num1.ToString();
        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = num1 * 10 + 9;
                txtValue.Text = num1.ToString();
            }
            else 
            {
                num2 = num2 * 10 + 9;
                txtValue.Text = num2.ToString();
            }
            
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string str = button.Content.ToString();
            int num = int.Parse(str);
            if (op == "")
            {
                num1 = num1 * 10 + 6;
                txtValue.Text = num1.ToString();
            }
            else
            {
                num2 = num2 * 10 + 6;
                txtValue.Text = num2.ToString();
            }

        }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            op = "+";
        }

        private void btn_eq_Click(object sender, RoutedEventArgs e)
        {
            int result = 0;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
            }
            txtValue.Text = result.ToString();
            op = "";
            num1 = result;
            num2 = 0;
        }

        // x^4 = x * x * x * x = x^3 * x;
        // x^3 = x * x * x = x^2 * x;
        // x^2 = x * x = x^1 * x;
        // x^1 = x = x^0 * x;
        // x^0 = 1;
        private double Pow(double x, int y)
        {
            if (y == 0)
                return 1;

            return Pow(x, y - 1) * x;
        }
    }
}
