using System.Windows;

namespace wpf_calculator.Trainings._2_EventHandling.tasks
{
    // Задача:
    // Скопировать разметку и размеры с заголовком с предыдущей работы Task_4_Window.xaml и логику обработки кнопок
    // Реализовать работу кнопок CE, C, <=, +/-

    // где CE удаляет число которое мы в данный момент вводим
    // С очищает все значения
    // <= удаляет одну цифру в числе
    // +/- меняет знак числа на противоположный
    public partial class Task_5_Window : Window
    {
        public Task_5_Window()
        {
            InitializeComponent();
        }
    }
}
