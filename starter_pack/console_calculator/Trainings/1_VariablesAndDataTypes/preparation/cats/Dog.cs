using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_calculator.Trainings._1_VariablesAndDataTypes.preparation.cats
{
    internal class Dog : Animal
    {
        public bool Collar { get; set; }

        public override void Say()
        {
            HardLogic();
            Console.WriteLine("Собака лает");
        }

        private void HardLogic() {
            Console.WriteLine("Очень тяжелая логика, много кода, собака идет зачем-то в базу данных... но это не нужно никому знать");
        }
    }
}
