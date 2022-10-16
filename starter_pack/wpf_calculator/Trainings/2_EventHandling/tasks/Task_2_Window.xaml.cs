using System.Windows;

namespace wpf_calculator.Trainings._2_EventHandling.tasks
{
    // Задача:
    // Скопировать разметку и размеры с заголовком с предыдущей работы Task_1_Window.xaml и логику обработки кнопок
    // Реализовать работу остальных кнопок для ввода чисел 4 5 6 7 8 9 0

    // Для обработки ввода всех чисел использовать только одну функцию - btn_num_Click
    // чтобы не было повторяющегося кода и 10 функций для каждой кнопки
    // Для этого необходимо использовать данные из объекта sender
    public partial class Task_2_Window : Window
    {
        public Task_2_Window()
        {
            InitializeComponent();
        }
    }
}
