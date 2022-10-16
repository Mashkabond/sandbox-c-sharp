using System.Windows;

namespace wpf_calculator.Trainings._3_WorkWithStrings.tasks
{
    // Задача:
    // Скопировать разметку и размеры с заголовком с предыдущей работы Task_1_Window.xaml и логику обработки кнопок
    // Реализовать работу кнопки <= для дробных чисел
    // Для этого будем рассматривать double как строку, удалять последний символ и снова преобразовывать в double
    public partial class Task_2_Window : Window
    {
        public Task_2_Window()
        {
            InitializeComponent();
        }
    }
}
