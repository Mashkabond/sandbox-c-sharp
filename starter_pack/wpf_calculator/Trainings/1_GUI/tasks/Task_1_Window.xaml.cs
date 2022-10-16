using System.Windows;

namespace wpf_calculator.Trainings._1_GUI.tasks
{
    // Задача:
    // Описать разметку графического калькулятора со следующими параметрами:
    //       Заголовок окна - Calculator
    //       Размер окна - 450х300
    //       Задать сетку из 4 колонок и 7 строчек
    // Расположить кнопки и текстовое поле по заданной сетке:
    //      <текстовое поле>
    //      min max avg x^y
    //      CE  C   <=   /
    //      7   8   9    *
    //      4   5   6    -
    //      1   2   3    +
    //     +/-  0   ,    =
    public partial class Task_1_Window : Window
    {
        public Task_1_Window()
        {
            InitializeComponent();
        }
    }
}
