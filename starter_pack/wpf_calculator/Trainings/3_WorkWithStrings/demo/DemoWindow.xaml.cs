using System.Windows;

namespace wpf_calculator.Trainings._3_WorkWithStrings.demo
{

    public partial class DemoWindow : Window
    {
        public DemoWindow()
        {
            InitializeComponent();
        }

        private void btn_test_Click(object sender, RoutedEventArgs e)
        {
            // Конкатенация строк
            string str1 = "Привет, ";
            string str2 = "мир!";

            string str = str1 + str2;
            // string str += str2;
            txtValue1.Text = str;


            // Длина строки
            int length = str1.Length;
            txtValue2.Text = length.ToString();

            // Символы
            char a = 'a';
            char b = 'b';

            int aInt = (int)a;
            int bInt = (int)b;

            char c = (char)((int)b + 1);

            for (int i = aInt; i <= (int)'z'; i++)
            {
                txtValue3.Text += (char)i;
            }

            // Доступ к элементу
            char cFirst = str[0];               // Первый символ
            char cLast = str[str.Length - 1];   // Последний символ

            for (int i = 0; i < str.Length; i++)
            {
                txtValue4.Text += str[i] + " ";
            }

            str = str.Remove(1, 1);
            str = str.Remove(str.Length - 1, 1);
            txtValue5.Text = str;
        }
    }
}
